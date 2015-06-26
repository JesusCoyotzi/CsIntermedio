#define EXITO 0
#define TRUNCADO -1
#define VACIO 250

int LedT=8;
int temp,sal;
String str="";
int time=500;

int Comando(String *cmd);

void setup(){
  Serial.begin(9600);
  pinMode(LedT,OUTPUT);
}

void loop(){
  int estado;
  temp=analogRead(A0);
  estado=Comando(&str);
  if(estado==EXITO)
  {
    if(str=="1#")
    {
      sal=  temp;//map(temp,0,1024,0,150);
      Serial.println(sal);
      delay(time);
     }  
    
    if(str=="2#")
    {
      Serial.println("\x03");
    }
    if(str=="3#")
    {
      Serial.println("hola");
      delay(time);
    }
  }
  else
  {
    digitalWrite(LedT,HIGH);
    delay(time*2);
  }
  
  
}
int Comando (String *cmd){
  char serialByte;
   int edo=EXITO;
   
  if(Serial.available())
  {
    *cmd="";
   do{
     
      serialByte=Serial.read();
      //Serial.println(serialByte);
      *cmd=*cmd+serialByte;
      delay(15);//WTF?
    }while(serialByte != '#' && Serial.available());
   
 // Serial.println(*cmd); 
 }

   //Serial.println(edo);
   return edo;
}
