using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Укажиите задание 1-4");
        int choose = Convert.ToInt32(Console.ReadLine());
        switch (choose){
        case 1:
            OutPut.Message();
            int priceCar;
            Console.Write("Введите цену автомобиля: ");
            priceCar = Convert.ToInt32(Console.ReadLine());

            OPK opk = new OPK(priceCar);
            opk.NameVehicle = "ОСКОЛБЕТОН";

            opk.Music();

            OutPut.Message();
            int speedPlane;
            Console.Write("Укажите скорость самолета: ");
            speedPlane = Convert.ToInt32(Console.ReadLine());

            Plane plane = new Plane();
            plane.MaxSpeed = speedPlane;

            plane.ImpactToPeople();

            OutPut.Message();
            int Balance = 100;
            int SpeedMixer;
            Console.Write("Укажите, сколько оборотов в минуту вам нужно: ");
            SpeedMixer = Convert.ToInt32(Console.ReadLine());

            Mixer mixer = new Mixer(Balance);
            mixer.NameVehicle = "ОСКОЛБЕТОН";
            mixer.priceToTurn = 10;
            mixer.MaxSpeed = SpeedMixer;

            mixer.StartToMix();

            OutPut.Message();
            break;
        case 2:
                Phone myHomePhone = new Phone("Poco", "79553167515");
                myHomePhone.Call("75156712632");

                Smartphone myWorkPhone = new Smartphone("Sumpsunc", "75156712632", 80.5);
                myWorkPhone.Call("01");
                myWorkPhone.Shoot();

                Console.ReadKey(true);
                break;
        case 3:
                Human FirstHuman = new Human("Максим Г.", 18, "М");
                Human SecondHuman = new Human("Анна Д.", 19, "W");

                Worker FirstWorker = new Worker("Максим Г.", 18, "М", "junior");
                Worker SecondWorker = new Worker("Анна Д.", 19, "W", "senior");

                Console.WriteLine($"Человек: {FirstHuman.Name}, {FirstHuman.Age} лет, {FirstHuman.Gender} пола\n");
                Console.WriteLine($"Человек: {SecondHuman.Name}, {SecondHuman.Age} лет, {SecondHuman.Gender} пола\n");

                Console.WriteLine($"Человек: {FirstWorker.Name}, {FirstWorker.Age} лет, {FirstWorker.Gender} пола, занимает должность: {FirstWorker.Status}\n");
                Console.WriteLine($"Человек: {SecondWorker.Name}, {SecondWorker.Age} лет, {SecondWorker.Gender} пола, занимает должность: {SecondWorker.Status}\n");
                break;
        case 4:
                break;
        }
    }
}
//Задание 1
class Phone
{
    public Phone(string model, string number)
    {
        Model = model;
        Number = number;
    }
    public string Model { get; set; }
    public string Number { get; set; }

    public void Call(string number)
    {
        Console.WriteLine($"Вызов по номеру: {number} ");
    }
}

class Smartphone : Phone
{
    public Smartphone(string model, string number, double cameraResolution)

        : base(model, number)
    {
        CameraResolution = cameraResolution;
    }
    public double CameraResolution { get; set; }
    public void Shoot()
    {
        Console.WriteLine("Снимок сделан");
    }
}
//Задание 2
static class OutPut
{
    static public void Message()
    {
        Console.WriteLine("\nHello\n");
    }
}
class Vehicle
{
    public string NameVehicle { get; set; }
    public int MaxSpeed { get; set; }
}
class OPK : Vehicle
{
    private string carModel;
    private int priceCar { get; set; }
    public OPK(int priceVehicle)
    {
        this.priceCar = priceVehicle;
    }


    private string ModelCar()
    {
        string car = "Я проходила практику в ОСКОЛБЕТОН";
        return car;
    }
    public OPK() { }

    private bool TimeTechnic()
    {
        if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday) return true;
        else return false;
    }
    public void Music()
    {
        TimeSpan startTime = new TimeSpan(9, 0, 0);
        TimeSpan endTime = new TimeSpan(18, 0, 0);

        if (priceCar >= 80000)
        {

            if (!TimeTechnic())
            {
                if (DateTime.Now.TimeOfDay >= startTime && DateTime.Now.TimeOfDay <= endTime)
                {
                    if (DateTime.Now.TimeOfDay >= startTime && DateTime.Now.TimeOfDay <= new TimeSpan(9, 5, 0))
                    {
                        Console.WriteLine($"Советую бежать, {NameVehicle} уже почти включила музыку. У вас осталось {_ = (new TimeSpan(9, 5, 0)) - startTime}\n");
                    }
                    else
                    {
                        Console.WriteLine($"Скорее всего вы уже не видите данное сообщение, {NameVehicle} все-таки смогла...\n");
                    }
                }
                else
                {
                    Console.WriteLine($"Тех закрыт, {NameVehicle} ищет новую композицию.\n");
                }
            }
            else
            {
                Console.WriteLine($"Вам повезло, в воскресенье {NameVehicle} спит.\n");
            }
        }
        else
        {
            Console.WriteLine($"Вам повезло, {NameVehicle} развалилась по дороге\n");
        }
    }
}
class Plane : Vehicle
{
    private bool checkError()
    {
        if (MaxSpeed <= 60)
        {
            return false;
        }
        return true;
    }
    public void ImpactToPeople()
    {
        if (checkError())
        {
            Console.WriteLine("Процесс опыления запущен...\n");
        }
        else
        {
            Console.WriteLine($"Хлеба не будет, {MaxSpeed} km/h не хватило для взлета.\n");
        }
    }
}
class Mixer : Vehicle
{
    public int priceToTurn { get; set; }
    private int Balance { get; set; }
    public Mixer(int balance)
    {
        this.Balance = balance;
    }

    private int priceToMix()
    {
        return MaxSpeed / priceToTurn;
    }
    private bool Payment()
    {
        if (Balance - priceToMix() >= 0)
        {
            Balance = Balance - priceToMix();
            return true;
        }
        return false;
    }
    public void StartToMix()
    {
        if (Payment())
        {
            Console.WriteLine($"\nЕдинственная фунция бетономешалки работает исправно, за {MaxSpeed} оборотов вам пришлось отдать {priceToMix()} рублей.\n\nВаш текущий баланс: {Balance}");
        }
        else
        {
            Console.WriteLine($"Денег нет, но вы держитесь");
        }
    }
}
//Задание 3
class Human
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public Human(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }
}

class Worker : Human
{
    public string Status { get; set; }
    public Worker(string name, int age, string gender, string status) : base(name, age, gender)
    {
        Status = status;
    }
}
//Задание 4