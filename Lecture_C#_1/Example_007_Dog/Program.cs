double speed_man1 = 1;
double speed_man2 = 2;
double speed_dog = 3;
int hum = 2;
int count = 0;
double time = 0;
double distance = 10000;

while (distance>2)
{
    if (hum == 2)
    {
        time = distance/(speed_dog + speed_man2);
        distance =  distance - (speed_man1 + speed_man2)*time;
        count++;
        hum = 1;
    } 
    else 
    {
        time = distance/(speed_dog + speed_man1);
        distance =  distance - (speed_man1 + speed_man2)*time;
        count++;
        hum = 2;
    }
    
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз");
