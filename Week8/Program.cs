using Week8;

Letter l1 = new Letter("001", 0.1);
Letter l2 = new Letter("002", 0.2);

Parcel p1 = new Parcel("003", 7.3, "30x20x15" );
Parcel p2 = new Parcel("004", 12.6, "30x50x35" );

l1.PrintInfo();
p1.PrintInfo();

CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();

myCargo.AddItem(l1);
myCargo.AddItem(l2);
myCargo.AddItem(p1);
myCargo.AddItem(p2);

Console.WriteLine(myCargo.GetTotalCost() + " грн");




