:protoc.exe   --csharp_out=./    Pack2/CallMessage.proto,Pack2/DefeatMessage.proto 

for %%i in (Pack2/DefeatMessage.proto ) do (protoc.exe   --java_out=./Pack2  %%i)

pause