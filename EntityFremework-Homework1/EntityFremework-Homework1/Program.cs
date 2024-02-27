
using EntityFremework_Homework1.DAL;
using EntityFremework_Homework1.Models;

AppDbContext appDbContext = new AppDbContext();




string opt;
do
{

    Console.WriteLine("1 Brand Add :");
    Console.WriteLine("2 GetAll Brands :");
    Console.WriteLine("3 Delete Brand");
	Console.WriteLine("4 First Brand");
	Console.WriteLine("5 Update Brand");
    opt = Console.ReadLine();


	switch (opt)
	{
		case "1":
            Console.WriteLine("Name:");
			string name = Console.ReadLine();

            Console.WriteLine("Date:");
			string dateopt = Console.ReadLine();
			DateTime date = Convert.ToDateTime(dateopt);


            Brand brand = new Brand()
			{
				Name = name,
				Date = date
			};
			appDbContext.Add(brand);
			appDbContext.SaveChanges();
			break;
		case "2":
			foreach (var item in GettAll())
			{
                Console.WriteLine(item);
            };
            break; 
		case "3":
			DeleteBrand();
            break;
		case "4":
            Console.WriteLine(GetFirstGroup());
            break;
		case "5":
            Console.WriteLine("Name:");
            name = Console.ReadLine();


            Console.WriteLine("Date :");
            date = Convert.ToDateTime(Console.ReadLine());
			UpdateGroup(name,date);
            break;
		default:
			break;
	}
} while (opt != "0");


List<Brand> GettAll()
{
	return appDbContext.Brands.ToList();
}



Brand GetFirstGroup()
{
	return appDbContext.Brands.First();
}

void DeleteBrand()
{
	var brand = appDbContext.Brands.First();
	appDbContext.Brands.Remove(brand);
	appDbContext.SaveChanges();
}


void UpdateGroup(string name,DateTime dateTime)
{
    var brand = appDbContext.Brands.First();
    
	brand.Name = name;
	brand.Date = dateTime;
    appDbContext.SaveChanges();
}