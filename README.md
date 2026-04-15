# ProGuide
Dieses Projekt ist ein Windows Forms-basiertes Programmier-Projektmanager-Tool, das Funktionen wie Zeitplanung, Aufgabenverwaltung und Projektübersicht bietet. Das Ziel des Tools ist es, Teams und Einzelpersonen bei der Organisation und Verwaltung von Projekten zu unterstützen.

## Inhalt
* [Gruppenmitglieder ](#Gruppenmitglieder)
* [Vor der ersten Nutzung](#vor-der-ersten-nutzung)
* [Projektstruktur](#projektstruktur)


## Gruppenmitglieder 


Team Fuchs:
- Nealjade Laluna
- Geena Tabea Losse
- Thuy Trang Hoang
- Ugur Muhammed Ekber Bektas


## Vor der ersten Nutzung
### JSON-Datei
- Im `Properties`-Ordner ist eine JSON-Datei mit dem Namen `appsettings.json`.  
- Starte das Programm, um eine Fehlermeldung zu erhalten, die zeigt, in welchen Pfad die Datei `appsettings.json` erwartet wird.  
- Verschiebe die Datei `appsettings.json` aus dem `Properties`-Ordner in den angegebenen Zielpfad.  
- Userdaten können über die Tabelle `User` herausgefunden werden.  
  Sonst sind die Standarddaten:  
  - **Usernamen**: `Login1`, `Login2`, `Login3`, `UserTest`, `Test1`, `Test23`, `Test2`, `Test5`  
  - **Passwort**: `1234` für alle Benutzer.

### API-Key
- Öffnen Sie das Verzeichnis ```AI/AIAssistance``` und die Datei `AI_Assistance.cs`.
Gehen Sie zur Zeile **17** und fügen Sie Ihren API-Schlüssel innerhalb von Anführungszeichen `""` hinzu :
```C#
{
       string apiKey = "";
}
```
- Öffnen Sie das Verzeichnis ```AI/AIFindTopic```  und die Datei `TopicAI_Assistance.cs`.
Gehen Sie auch hier zur Zeile **17** und fügen Sie Ihren API-Schlüssel innerhalb von Anführungszeichen `""` hinzu. Nach dem Einfügen des API-Schlüssels können Sie die KI-Funktionalitäten verwenden und mit der KI chatten.

## Projektstruktur

Um Sicherzustellen das nur ein Nutzer auf ein Desktop eingeloggt sein kann, wird ein Singleton Pattern verwendet. Dabei werden wichtige Informationen gespeichert. Beim LogOut wird es "reseted", damit man sich wieder Anmelden kann. So werden colficts verhindert.

Das folgende Diagramm zeigt die Struktur des Projekts:

```plaintext
Programmierprojekt/
├── AI/
│   ├── AIAssistance/
│   │   ├── AI_Assistance.cs          
│   │   ├── AssistanceForm.cs      
│   │   ├── ChatViewerForm.cs      
│   ├── AIFindTopic/
│   │   ├── ChatTopicViewerForm.cs
│   │   ├── TopicAI_Assistance.cs
│   │   ├── TopicForm.cs
├── CodeOverview/
│   ├── UploadCodeMenu.cs
├── DiagramManagement/
│   ├── Arrow.cs
│   ├── Circle.cs
│   ├── CreateNewDiagramm.cs
│   ├── Curve.cs
│   ├── CurveClickHandler.cs
│   ├── CurveContainer.cs
│   ├── Drawing.cs
│   ├── ISurface.cs
│   ├── Klassendiagramm.cs
│   ├── Komponentendiagramm.cs
│   ├── Line.cs
│   ├── Oval.cs
│   ├── Point.cs
│   ├── PointVectorBase.cs
│   ├── Polyline.cs
│   ├── Rectangle.cs
│   ├── StatusManager.cs
│   ├── StatusManagerEventArgs.cs
│   ├── TechnischeSpezifikationenDiagramme.cs
│   ├── TransparentTextBox.cs
│   ├── UseCaseDiagramm.cs
│   ├── Vector.cs
├── Homepage/
│   ├── HomepageForm.cs
├── Images/
├── Managers&Menus/
│   ├── AccountMenu/
│   │   ├── AccountMenu.cs
│   ├── GroupMenu/
│   │   ├── GroupMenu.cs
│   │   ├── SubFormGroup.cs
│   ├── ProjectMenu/
│   │   ├── ProjectMenu.cs
│   │   ├── SubFormProject.cs
│   ├── SQL-Tables.json
│   ├── FormManager.cs
│   ├── IUserSession.cs
│   ├── Login.cs
│   ├── UserSession.cs
├── Properties/
│   ├── ServiceDependencies/local
│   ├── appsettings.json
│   ├── Resources.Designer.cs
├── Sidebars/
│   ├── Sidebar.cs
│   ├── pre-Sidebar.cs
├── StepsOverview/
│   ├── StepsOverviewForm.cs
├── TimeTable/
│   ├── CreateToDoForm.cs
│   ├── ListViewItemComparer.cs
│   ├── TimeTableForm.cs
├── Topbar/
│   ├── TopBarControls.cs
├──Program.cs




