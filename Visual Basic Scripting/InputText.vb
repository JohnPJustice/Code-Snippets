Option Explicit 
Dim Efile, objFSO, myFile, myFilePath, objFolder, myFolder
Const ForWriting = 2
myFilePath = "text.txt"' your text file
myFolder = "Folder\"'your folder make sure you add/ to the end otherwise you may have some trouble running the script
eFile = InputBox ( _
  "Statement in the input box header", _
  "Statement in the input box", _
  "Default text in the textbox" _
  )
Set objFSO = CreateObject("Scritpting.FileSystemObject")
If objFSO.FolderExists(myFolder) Then
'nothing 
Else 
Set objFolder = objFSO.CreateFolder("Foler\")'Folder location or where it should be.
End If
Set objFSO =  CreateObject("Scripting.FileSystemObject")
If objFSO.FileExists(myFilePath) Then
Set myFile = objFSO.OpenTextFile("Text.txt",ForWriting)'text location  
myFile.WriteLine(eFile)
myFile.Close
Else
Set objFSO = CreateObject("Scripting.FileSystemObject")
Set myFile = objFSO.CreateTextFile("text.txt",ForWriting)
myFile.WriteLine(eFile)
myFile.Close
End If