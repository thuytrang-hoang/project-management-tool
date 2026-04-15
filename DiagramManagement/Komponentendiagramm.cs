using Programmierprojekt.DiagramManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programmierprojekt;
using static Programmierprojekt.DiagramManagement.Curve;
using Point = Programmierprojekt.DiagramManagement.Point;
using Rectangle = Programmierprojekt.DiagramManagement.Rectangle;

namespace Programmierprojekt.DiagramManagement
{
    // Form for creating and managing "Komponentendiagramm"
    public partial class Komponentendiagramm : Form
    {
        // Drawing canvas containing all diagram elements
        private Drawing _drawing = new Drawing(new Curve[0]);

        // Variables to manage user interactions
        private CurveClickHandler _clickHandler = null;
        private Curve _currentCurve = null;
        private object _selectedCurve = null;
        private Point _previousMousePosition = null;
        private TransparentTextBox _selectedTextBox = null;
        private List<TransparentTextBox> _textBoxes = new List<TransparentTextBox>();

        // Interaction modes
        private bool _isInSelectionMode = false;
        private bool _isInDeleteMode = false;
        private bool _isInTextBoxMode = false;
        private bool _isDashedLine = false;

        private Pen p = new Pen(Color.Black);

        // Constructor initializes form properties and event handlers
        public Komponentendiagramm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Center window

            _drawing.Redraw += OnRedraw;
            StatusManager.Instance.StatusMessageChanged += (s, e) => toolStripStatusLabel.Text = e.Message;
        }

        // Redraws the picture box when an update is needed
        private void OnRedraw(Object sender, EventArgs e)
        {
            pictureBox.Invalidate();
        }

        // Sets the transformation for converting world coordinates to screen coordinates
        private void SetGraphicsTransformToWorld(Graphics g)
        {
            g.ResetTransform();
            g.ScaleTransform(1f, -1f);
            g.TranslateTransform(0f, -pictureBox.Height);
        }

        // Converts screen coordinates to world coordinates
        private Point TransformScreenToWorld(System.Drawing.Point screenPoint)
        {
            return new Point(screenPoint.X, pictureBox.Height - screenPoint.Y);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Loads a saved drawing from a file
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = ".drw",
                CheckPathExists = true,
                Filter = "Drawing files (*.drw)|",
                InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = "Please select a drawing file to save."
            };

            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                _drawing.Load(sfd.FileName);
            }
        }

        // Saves the current drawing to a file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                AddExtension = true,
                DefaultExt = ".drw",
                CheckPathExists = true,
                Filter = "Drawing files (*.drw)|",
                InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = "Please select a drawing file to save."
            };
            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                _drawing.Save(sfd.FileName);
            }
        }

        // Clears all curves and text boxes from the drawing
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _drawing.RemoveAllCurves();

            foreach (var textBox in _textBoxes)
            {
                pictureBox.Controls.Remove(textBox);
            }
            _textBoxes.Clear();

            List<Control> controlsToRemove = new List<Control>();
            foreach (Control control in pictureBox.Controls)
            {
                if (control is PictureBox) // Für Bilder oder andere spezifische Controls
                {
                    controlsToRemove.Add(control);
                }
            }

            foreach (var control in controlsToRemove)
            {
                pictureBox.Controls.Remove(control);
            }

            pictureBox.Invalidate();

        }


        // Following functions were developed with support from ChatGPT after first implematation, which provided suggestions and optimizations during the implementation process

        // Handles user clicks to create a textbox
        private void textbox_Click(object sender, EventArgs e)
        {
            _isInTextBoxMode = true;

            _currentCurve = null;
            _clickHandler = (System.Drawing.Point clickPoint, MouseButtons buttons, int screenHeight, ref Curve currentElement, out string statusMessage) =>
            {
                return TransparentTextBox.TextBoxClickHandler(clickPoint, buttons, screenHeight, out statusMessage);
            };
            StatusManager.Instance.SetStatus(TransparentTextBox.StartMessage);

        }

        // Handles adding and selecting text boxes
        public void AddTextBoxToList(TransparentTextBox textBox)
        {
            if (!_textBoxes.Contains(textBox))
            {
                _textBoxes.Add(textBox);
                pictureBox.Controls.Add(textBox);

                textBox.Click += (s, e) => SelectTextBox((TransparentTextBox)s);
                StatusManager.Instance.SetStatus("TextBox erfolgreich hinzugefügt.");
            }
            else
            {
                StatusManager.Instance.SetStatus("TextBox existiert bereits in der Liste.");
            }
        }

        // Selects a text box for interaction
        public void SelectTextBox(TransparentTextBox textBox)
        {
            _selectedTextBox = textBox;
            StatusManager.Instance.SetStatus($"TextBox ausgewählt: {textBox.Text}");
        }

        // Deletes the selected text box
        private void btnDeleteTextBox_Click(object sender, EventArgs e)
        {
            if (_selectedTextBox != null)
            {
                _textBoxes.Remove(_selectedTextBox);
                pictureBox.Controls.Remove(_selectedTextBox);
                _selectedTextBox = null;
                StatusManager.Instance.SetStatus("TextBox erfolgreich gelöscht.");

                pictureBox.Invalidate(); // Anzeige aktualisieren
            }
            else
            {
                StatusManager.Instance.SetStatus("Keine TextBox zum Löschen ausgewählt.");
            }
        }

        // Enables selection mode for selecting objects
        private void auswahlmodus_Click(object sender, EventArgs e)
        {
            _isInSelectionMode = !_isInSelectionMode;
            StatusManager.Instance.SetStatus(_isInSelectionMode
                ? "Auswahlmodus aktiviert"
                : "Erstellungsmodus aktiviert");
        }

        // Enables delete mode for removing objects
        private void removeButton_Click(object sender, EventArgs e)
        {

            _isInDeleteMode = !_isInDeleteMode;
            StatusManager.Instance.SetStatus(_isInDeleteMode
                ? "Löschen-Modus aktiviert. Klicken Sie auf Objekte zum Entfernen."
                : "Löschen-Modus deaktiviert.");
        }

        // Handles user clicks to create an arrow
        private void arrow_Click(object sender, EventArgs e)
        {
            _isInTextBoxMode = false;
            _currentCurve = null;
            _clickHandler = (System.Drawing.Point clickPoint, MouseButtons buttons, int screenHeight, ref Curve currentElement, out string statusMessage) =>
            {
                var result = Arrow.ArrowLineClickHandler(clickPoint, buttons, screenHeight, ref currentElement, out statusMessage);

                if (currentElement is Arrow arrow && result == ClickResult.Created)
                {
                    arrow.ArrowIsDashed = _isDashedLine;
                }
                return result;
            };
            StatusManager.Instance.SetStatus(Arrow.StartMessage);
        }

        // Handles user clicks to create a polyarrow
        private void polyArrow_Click(object sender, EventArgs e)
        {
            _isInTextBoxMode = false;
            _currentCurve = null;
            _clickHandler = (System.Drawing.Point clickPoint, MouseButtons buttons, int screenHeight, ref Curve currentElement, out string statusMessage) =>
            {
                var result = Arrow.ArrowPolylineClickHandler(clickPoint, buttons, screenHeight, ref currentElement, out statusMessage);

                if (currentElement is Arrow arrow && result == ClickResult.Created)
                {
                    arrow.ArrowIsDashed = _isDashedLine;
                }

                return result;
            };
            StatusManager.Instance.SetStatus(Arrow.StartMessage);
        }

        // Handles user clicks to create a line
        private void line_Click(object sender, EventArgs e)
        {
            _isInTextBoxMode = false;
            _currentCurve = null;

            _clickHandler = (System.Drawing.Point clickPoint, MouseButtons buttons, int screenHeight, ref Curve currentElement, out string statusMessage) =>
            {
                var result = Line.LineClickHandler(clickPoint, buttons, screenHeight, ref currentElement, out statusMessage);

                if (currentElement is Line line && result == ClickResult.Created)
                {
                    line.IsDashed = _isDashedLine;
                }
                return result;
            };
            StatusManager.Instance.SetStatus(Line.StartMessage);
        }

        // Handles user clicks to create a polyline
        private void polyline_Click(object sender, EventArgs e)
        {
            _isInTextBoxMode = false;
            _currentCurve = null;
            _clickHandler = (System.Drawing.Point clickPoint, MouseButtons buttons, int screenHeight, ref Curve currentElement, out string statusMessage) =>
            {
                var result = Polyline.PolylineClickHandler(clickPoint, buttons, screenHeight, ref currentElement, out statusMessage);

                if (currentElement is Polyline polyline && result == ClickResult.Created)
                {
                    polyline.IsDashed = _isDashedLine;
                }

                return result;
            };
            StatusManager.Instance.SetStatus(Polyline.StartMessage);
        }

        // Handles user clicks to create a rectangle        
        private void rectangle_Click(object sender, EventArgs e)
        {
            _isInTextBoxMode = false;
            _currentCurve = null;
            _clickHandler = Rectangle.RectangleClickHandler;
            StatusManager.Instance.SetStatus(Rectangle.StartMessage);

        }
       
        // Handles rendering the drawing and selected 
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {

            SetGraphicsTransformToWorld(e.Graphics);

            _drawing.Draw(e.Graphics);

            // drawing current curve, if excisting
            if (_currentCurve != null)
            {
                _currentCurve.Draw(e.Graphics);
            }
        }

        // Handles mouse click events in the drawing area
        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (_isInTextBoxMode && e.Button == MouseButtons.Left)
            {
                var location = new System.Drawing.Point(e.X, e.Y);
                var newTextBox = new TransparentTextBox
                {
                    Location = location,
                    Width = 150,
                    Height = 30,
                    Text = "Neue TextBox" // Standardtext hinzufügen
                };

                AddTextBoxToList(newTextBox);
                return; // TextBox-Erstellung abschließen

            }
            if (_isInSelectionMode && e.Button == MouseButtons.Left)
            {
                foreach (var textBox in _textBoxes)
                {
                    if (textBox.Bounds.Contains(e.Location))
                    {
                        _selectedTextBox = textBox; // TextBox auswählen
                        StatusManager.Instance.SetStatus($"TextBox zur Bewegung ausgewählt: {textBox.Text}");
                        return;
                    }
                }

                if (_selectedTextBox != null)
                {
                    MoveSelectedTextBoxToPosition(e.Location); // TextBox an neue Position bewegen
                    _selectedTextBox = null; // Auswahl aufheben
                }
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Point worldMousePosition = TransformScreenToWorld(e.Location);
            System.Drawing.Point systemPoint = new System.Drawing.Point((int)worldMousePosition.X, (int)worldMousePosition.Y);

            if (_isInDeleteMode)
            {
                for (int i = 0; i < _drawing.Curves.Count; i++)
                {
                    var curve = _drawing.Curves[i];
                    if (IsMouseOverCurve(curve, systemPoint))
                    {
                        _drawing.RemoveCurve(i);
                        pictureBox.Invalidate(); // refresh display
                        return;
                    }
                }
            }
            else if (_isInSelectionMode)
            {
                // Auswahlmodus
                foreach (var curve in _drawing.Curves)
                {
                    if (IsMouseOverCurve(curve, systemPoint))
                    {
                        _selectedCurve = curve;
                        _previousMousePosition = worldMousePosition;
                        return;
                    }
                }
            }
            else if (_isInTextBoxMode)
            {
                // Standardmodus: TextBox verschieben
                foreach (var textBox in _textBoxes)
                {
                    if (textBox.Bounds.Contains(e.Location))
                    {
                        _selectedCurve = textBox;
                        _previousMousePosition = worldMousePosition;
                        Console.WriteLine($"TextBox ausgewählt: {textBox.Text}");
                        return;
                    }
                }
            }
            else
            {
                if (_clickHandler != null)
                {
                    string statusMessage;
                    ClickResult result = _clickHandler(e.Location, e.Button, pictureBox.Height, ref _currentCurve, out statusMessage);
                    StatusManager.Instance.SetStatus(statusMessage);

                    if (result == ClickResult.Finished)
                    {
                        _drawing.AddCurve(_currentCurve);
                        _currentCurve = null;
                    }
                }
            }
        }
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_selectedCurve != null && e.Button == MouseButtons.Left)
            {
                Point worldMousePosition = TransformScreenToWorld(e.Location);

                int deltaX = (int)(worldMousePosition.X - _previousMousePosition.X);
                int deltaY = (int)(worldMousePosition.Y - _previousMousePosition.Y);

                if (_selectedCurve is Curve curve)
                {
                    curve.Move(deltaX, deltaY);
                }
                _previousMousePosition = worldMousePosition;

                pictureBox.Invalidate();
            }
        }
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _selectedCurve = null;
            }
        }

        // Checks whether the mouse is over a given curve
        private bool IsMouseOverCurve(Curve curve, System.Drawing.Point mousePosition)
        {
            if (curve is Line line)
            {
                return IsMouseNearLine(line, mousePosition, tolerance: 5);
            }
            else if (curve is Rectangle rectangle)
            {
                return IsMouseInsideRectangle(rectangle, mousePosition);
            }
            else if (curve is Polyline polyline)
            {
                return IsMouseNearPolyline(polyline, mousePosition, tolerance: 5);
            }
            else if (curve is Arrow arrow)
            {
                return IsMouseNearArrow(arrow, mousePosition, tolerance: 5);
            }

            return false;
        }
        private bool IsMouseNearLine(Line line, System.Drawing.Point mousePosition, int tolerance)
        {
            Point mousePoint = new Point(mousePosition.X, mousePosition.Y);

            Vector lineVector = new Vector(line.EndPoint.X - line.StartPoint.X, line.EndPoint.Y - line.StartPoint.Y);

            Vector pointVector = new Vector(mousePoint.X - line.StartPoint.X, mousePoint.Y - line.StartPoint.Y);

            double lengthSquared = lineVector.X * lineVector.X + lineVector.Y * lineVector.Y;
            double t = pointVector.DotProduct(lineVector) / lengthSquared;
            t = Math.Max(0, Math.Min(1, t));

            Point projection = new Point(
             line.StartPoint.X + t * lineVector.X,
             line.StartPoint.Y + t * lineVector.Y
             );

            double distanceToLine = mousePoint.DistanceTo(projection);

            return distanceToLine <= tolerance;
        }
        private bool IsMouseInsideRectangle(Rectangle rectangle, System.Drawing.Point mousePosition)
        {
            Point mousePoint = new Point(mousePosition.X, mousePosition.Y);

            double left = rectangle.CornerPoint.X;
            double right = rectangle.CornerPoint.X + rectangle.Width;
            double bottom = rectangle.CornerPoint.Y;
            double top = rectangle.CornerPoint.Y + rectangle.Height;

            return mousePoint.X >= left && mousePoint.X <= right &&
           mousePoint.Y >= bottom && mousePoint.Y <= top;
        }
        private bool IsMouseNearPolyline(Polyline polyline, System.Drawing.Point mousePosition, int tolerance)
        {
            bool isNear = false;
            Point mousePoint = new Point(mousePosition.X, mousePosition.Y);

            for (int i = 0; i < polyline.Points.Count - 1; i++)
            {
                Point startPoint = polyline.Points[i];
                Point endPoint = polyline.Points[i + 1];

                // procedure like IsMouseNearLine
                Vector lineVector = new Vector(endPoint.X - startPoint.X, endPoint.Y - startPoint.Y);
                Vector pointVector = new Vector(mousePoint.X - startPoint.X, mousePoint.Y - startPoint.Y);

                double lengthSquared = lineVector.X * lineVector.X + lineVector.Y * lineVector.Y;

                // If the length is zero, to avoid division by zero
                if (lengthSquared == 0)
                {
                    if (mousePoint.DistanceTo(startPoint) <= tolerance)
                    {
                        return true;
                    }
                    continue;
                }

                double t = pointVector.DotProduct(lineVector) / lengthSquared;
                t = Math.Max(0, Math.Min(1, t));

                Point projection = new Point(
                    startPoint.X + t * lineVector.X,
                    startPoint.Y + t * lineVector.Y
                );

                double distanceToSegment = mousePoint.DistanceTo(projection);

                if (distanceToSegment <= tolerance)
                    isNear = true;

            }

            return isNear;
        }
        private bool IsMouseNearArrow(Arrow arrow, System.Drawing.Point mousePosition, int tolerance)
        {
            bool isNear = false;
            if (arrow.ArrowLine != null)
            {
                if (IsMouseNearLine(arrow.ArrowLine, mousePosition, tolerance) == true)
                    isNear = true;

            }
            else if (arrow.ArrowPolyline != null)
            {
                if (IsMouseNearPolyline(arrow.ArrowPolyline, mousePosition, tolerance) == true)
                    isNear = true;
            }


            return isNear;
        }

        // Handles the toggling of dashed lines
        private void isDashed_Click(object sender, EventArgs e)
        {
            _isDashedLine = !_isDashedLine; // change to dashed or back to solid
            StatusManager.Instance.SetStatus(_isDashedLine ? "Gestrichelte Linien aktiviert." : "Gestrichelte Linien deaktiviert.");
            pictureBox.Invalidate();

        }

        // Handles user clicks to create images
        private void interfaceImage_Click(object sender, EventArgs e)
        {
            string imagePath = @"Images\InterfaceImage.png";
            CreateAndAddImage(imagePath, new Size(100, 100), new Point(50, 50));
        }
        private void interfaceTopImage_Click(object sender, EventArgs e)
        {
            string imagePath = @"Images\InterfaceTopImage.png";
            CreateAndAddImage(imagePath, new Size(120, 120), new Point(200, 50));
        }
        private void interfaceBottomImage_Click(object sender, EventArgs e)
        {
            string imagePath = @"Images\InterfaceBottomImage.png";
            CreateAndAddImage(imagePath, new Size(100, 100), new Point(50, 200));
        }
        private void interfaceRightImage_Click(object sender, EventArgs e)
        {
            string imagePath = @"Images\InterfaceRightImage.png";
            CreateAndAddImage(imagePath, new Size(100, 100), new Point(300, 50));
        }
        private void interfaceLeftImage_Click(object sender, EventArgs e)
        {
            string imagePath = @"Images\InterfaceLeftImage.png";
            CreateAndAddImage(imagePath, new Size(100, 100), new Point(50, 300));
        }
        private void artifactImage_Click(object sender, EventArgs e)
        {
            string imagePath = @"Images\ArtifactImage.png";
            CreateAndAddImage(imagePath, new Size(120, 120), new Point(150, 150));
        }
        private void componentImage_Click(object sender, EventArgs e)
        {
            string imagePath = @"Images\ComponentImage.png";
            CreateAndAddImage(imagePath, new Size(100, 100), new Point(100, 100));
        }
        private void portImage_Click(object sender, EventArgs e)
        {
            string imagePath = @"Images\PortImage.png";
            CreateAndAddImage(imagePath, new Size(80, 80), new Point(200, 200));
        }

        // Enables interaction with a user image through an additional function
        private void CreateAndAddImage(string imagePath, Size initialSize, Point initialLocation)
        {
            Bitmap image = new Bitmap(imagePath);

            PictureBox pictureBoxImage = new PictureBox
            {
                Image = image,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(100, 100),// size in the beginning
                Location = new System.Drawing.Point(50, 50), // first position
                BorderStyle = BorderStyle.FixedSingle
            };

            bool isDragging = false;
            System.Drawing.Point dragStartPoint = System.Drawing.Point.Empty;

            pictureBoxImage.MouseDown += (s, e) =>
            {
                if (_isInSelectionMode && e.Button == MouseButtons.Left)
                {
                    isDragging = true;
                    dragStartPoint = e.Location;
                }
                else if (_isInDeleteMode && e.Button == MouseButtons.Left)
                {
                    // Löschen des Bildes im Delete-Modus
                    pictureBox.Controls.Remove((PictureBox)s);
                    Console.WriteLine("Bild gelöscht.");
                }
            };

            pictureBoxImage.MouseMove += (s, e) =>
            {
                if (_isInSelectionMode && isDragging)
                {
                    var control = (PictureBox)s;
                    control.Left += e.X - dragStartPoint.X;
                    control.Top += e.Y - dragStartPoint.Y;
                }
            };

            pictureBoxImage.MouseUp += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    isDragging = false;
                }
            };

            pictureBoxImage.MouseWheel += (s, e) =>
            {
                if (_isInSelectionMode)
                {
                    var control = (PictureBox)s;
                    int scaleFactor = e.Delta > 0 ? 10 : -10;
                    control.Size = new Size(control.Width + scaleFactor, control.Height + scaleFactor);
                }
            };

            pictureBox.Controls.Add(pictureBoxImage);
            pictureBoxImage.BringToFront();
        }

        // Moves the selected text box to a new position
        private void MoveSelectedTextBoxToPosition(System.Drawing.Point newPosition)
        {
            if (_isInSelectionMode && _selectedTextBox != null)
            {
                _selectedTextBox.Location = newPosition;
                StatusManager.Instance.SetStatus($"TextBox verschoben zu: ({newPosition.X}, {newPosition.Y})");
                pictureBox.Invalidate(); // Anzeige aktualisieren
            }
            else
            {
                StatusManager.Instance.SetStatus("Keine TextBox ausgewählt oder Auswahlmodus nicht aktiviert.");
            }
        }
    }

}
