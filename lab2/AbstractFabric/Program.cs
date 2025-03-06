using AbstractFabric.classes.Factories;
using AbstractFabric.interfaces;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Виробництво Epple:");
IDeviceFactory iproneFactory = new EppleFactory();
ILaptop iproneLaptop = iproneFactory.CreateLaptop();
INetbook iproneNetbook = iproneFactory.CreateNetbook();
IEBook iproneEBook = iproneFactory.CreateEBook();
ISmartphone iproneSmartphone = iproneFactory.CreateSmartphone();

iproneLaptop.ShowInfo();
iproneNetbook.ShowInfo();
iproneEBook.ShowInfo();
iproneSmartphone.ShowInfo();

Console.WriteLine("\nВиробництво Kiaomi:");
IDeviceFactory kiaomiFactory = new KiaomiFactory();
ILaptop kiaomiLaptop = kiaomiFactory.CreateLaptop();
INetbook kiaomiNetbook = kiaomiFactory.CreateNetbook();
IEBook kiaomiEBook = kiaomiFactory.CreateEBook();
ISmartphone kiaomiSmartphone = kiaomiFactory.CreateSmartphone();

kiaomiLaptop.ShowInfo();
kiaomiNetbook.ShowInfo();
kiaomiEBook.ShowInfo();
kiaomiSmartphone.ShowInfo();

Console.WriteLine("\nВиробництво Balaxy:");
IDeviceFactory balaxyFactory = new BalaxyFactory();
ILaptop balaxyLaptop = balaxyFactory.CreateLaptop();
INetbook balaxyNetbook = balaxyFactory.CreateNetbook();
IEBook balaxyEBook = balaxyFactory.CreateEBook();
ISmartphone balaxySmartphone = balaxyFactory.CreateSmartphone();

balaxyLaptop.ShowInfo();
balaxyNetbook.ShowInfo();
balaxyEBook.ShowInfo();
balaxySmartphone.ShowInfo();