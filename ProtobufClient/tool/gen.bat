:protoc.exe   --csharp_out=./    Pack2/CallMessage.proto,Pack2/DefeatMessage.proto 

for %%i in (Pack2/BackMessage.proto , Pack2/CallMessage.proto , Pack2/DefeatMessage.proto ) do (protoc.exe   --csharp_out=./Pack2  %%i)

pause