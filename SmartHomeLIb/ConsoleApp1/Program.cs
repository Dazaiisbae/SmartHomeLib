using SmartHomeLibrary;

var hub = new SmartHomeHub();

// You will add your devices here once you implement them.
// Example flow you should be able to run by the end:
// - create devices
// - SetOnline(true)
// - TurnOn()
// - ApplyModeToAll("Night")
// - PrintAllStatuses()

Console.WriteLine("SmartHomeConsole starting...");
Console.WriteLine("Add device creation and hub actions once classes are implemented.");

SecurityCamera cam1 = new SecurityCamera("cam001", "Living Room cam");
SecurityCamera cam2 = new SecurityCamera("cam001", "Bedroom cam");
SecurityCamera cam3 = new SecurityCamera("cam001", "Kitchen cam");
SmartLight bulb1 = new SmartLight("Bulb001", "LivingRoom bulb");
SmartLight bulb2 = new SmartLight("Bulb002", "Bedroom bulb");
SmartLight bulb3 = new SmartLight("Bulb003", "Kitchen bulb");
List<SmartDevice> devices = new List<SmartDevice>
{
    cam1,
    cam2,
    cam3,
    bulb1,
    bulb2,
    bulb3

};

foreach (SmartDevice device in devices)
{
    device.SetOnline(true);
    device.TurnOn();
    device.ApplyMode("Reading");
    Console.WriteLine(device.GetStatus());
}




