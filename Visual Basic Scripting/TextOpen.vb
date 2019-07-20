    
Option Explicit
Dim objFSO, myTextFile, myOpenTextFile, textData, line
Const ForReading = 1
myTextFile = "Text.txt"'your text file that you want to be read
Set objFSO = CreateObject("Scripting.FileSystemObject")
Set textData = objFSO.OpenTextFile("Text.txt", ForReading)
Do Until textData.AtEndOfStream
  line = textData.ReadLine
  Wscript.Echo line
Loop