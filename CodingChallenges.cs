//=================================================================================================================
//=======================================================================================================================
//===========================================================================================================================
//-------------------------------------------------coding challenge----------------------------------------------------------//

//Q1.

int count2 = 0;
foreach (var item in Passengers)
{
   if (item == SearchName1)
   {
       Console.WriteLine($"{SearchName1} is in the array ");
       break;
       count2++;
   }
}
if (count2 == 0)
{
   Console.WriteLine("Item cannot found");
}



//==================d================

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Length is:");
for (int i = 0; i < pnames.Length; i++)
{
   int count = 0;
   foreach (var item in pnames[i])
   {



       if (item == ' ')
           continue;
       count++;
   }
   Console.WriteLine($"Length of {pnames[i]} is {count}");
}








////====================f==================duplicates

Console.WriteLine();
var duplicates = new string[Passengers.Length];
int k = 0;
foreach (var item in Passengers)
{
   int count1 = 0;
   foreach (var name in Passengers)
   {
       if (item == name)
       {
           count1++;
       }
       if (count1 >= 2)
       {
           bool hasFoundMatch = false;
           foreach (var str in duplicates)
           {
               if (str == item)
               {
                   hasFoundMatch = true;
                   break;
               }
           }
           if (!hasFoundMatch)
               duplicates[k++] = item;
       }
   }

}
Console.WriteLine(String.Join("  ", duplicates));





















//Q2.

var f1 = new flight2()
{
   BookingTime = 6,
   Fare = 50000,

};
f1.ShowRise();
f1.ShowData();

//--------------------------------------------------


//Q3.

var  Fare =  new decimal[4];
for(int i = 0; i < Fare.Length; i++)
{
   Fare[i] =decimal.Parse( Console.ReadLine());
}

decimal max = Fare.Max();
decimal min = Fare.Min();
Console.WriteLine($"the maximum value is{max} and minimum is {min}");


decimal temp1 = 0;
for(int i = 0; i < Fare.Length; i++)
{
   for(int j = i+1; j < Fare.Length; j++)
   {
       if (Fare[i] > Fare[j])
       {
           temp1 = Fare[j];
           Fare[j]= Fare[i];
           Fare[i] = temp1;

       }
   }
}
Console.WriteLine("ascending order");
foreach(int i in Fare)
{
   Console.WriteLine(i);
}

decimal temp2 = 0;

for (int i = 0; i < Fare.Length; i++)
{
   for (int j = i + 1; j < Fare.Length; j++)
   {
       if (Fare[i] < Fare[j])
       {
           temp2 = Fare[j];
           Fare[j] = Fare[i];
           Fare[i] = temp2;

       }
   }
}
Console.WriteLine("descending order");
foreach (int item in Fare)
{
   Console.WriteLine(item);
}
//search input
Console.WriteLine("search a name");
var search = decimal.Parse(Console.ReadLine());

int count = 0;
foreach(int item in Fare)


{
   if(search == item)
   {
       Console.WriteLine("item found");
       count++;
       return;

   }
  


}
if (count == 0)
{
   Console.WriteLine("item not found");
}

//!!!!!!!!!! duplication











//----------------------------------------------------
//Q4.

Console.WriteLine("enter your birthday");
DateTime  Birthday = DateTime.Parse(Console.ReadLine());
Console.WriteLine(Birthday);
DateTime Today = DateTime.Now;
Console.WriteLine(Today);
int Ageyrs = Today.Year - Birthday.Year;
Console.WriteLine(Ageyrs);
int Agemnth = Ageyrs * 12 + (Today.Month - Birthday.Month);
Console.WriteLine(Agemnth);
int Agedays =( Agemnth*30 )+ (Today.Day - Birthday.Day);
Console.WriteLine(Agedays);
int AgeWks = (Agedays / 7);
Console.WriteLine(AgeWks);
int Agehrs = (Agedays * 24) + (Today.Hour - Birthday.Hour);
Console.WriteLine(Agehrs);

//-----------------------------------------------------------------------------------------------------

//Q5.

var fare = new List<decimal>();
var even = new decimal[10] ;
var odd = new decimal[10] ;
int x=0 ;
int y=0 ;
for (int i = 0; i < 10; i++)
{
   fare.Add(decimal.Parse(Console.ReadLine()));
}


foreach (var i in fare)
{
   if (i % 2 == 0)
   {
       even[x] = i;
       x++;
   }
   else
   {
       odd[y] = i;
       y++;
   }

}


foreach(decimal i in even)
{
   Console.WriteLine(i);
}
foreach (decimal o in odd)
{
   Console.WriteLine(o);
}

//---------------------------------------------------------------------------------------------------------------------------------
//Q6.









//---------------------------------------------------------------------------------------------------------------
//Q7.

var p1 = new Miles7()
{
   Name = "aish",
   TotalMiles = 25000,
};



p1.Point();
p1.ShowData();
//-----------------------------------------------------------------------------------------------------------------------------------
//Q8.

var fares = new int[4];
var destination = new string [4];
for (int i = 0; i < fares.Length; i++)
{
   fares[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < destination.Length; i++)
{
   destination[i] = Console.ReadLine();
}
int no = int.Parse(Console.ReadLine());
Console.WriteLine($" destinstion:{destination[no]} and fare: {fares[no]}");














//Q9.



for (int i = 0; i < 10; i++)
{
   Console.WriteLine("enter dob");
   DateTime dob = DateTime.Parse(Console.ReadLine()).Date;
   DateTime Today = DateTime.Now.Date;
   int Age = Today.Year - dob.Year;
   Console.WriteLine(Age);
   if(Age < 10)
   {
       Console.WriteLine("kid");
   }
   else if (Age > 10 && Age < 30)
   {
       Console.WriteLine("Youth");
   }
   else if(Age > 30 && Age < 60)
   {
       Console.WriteLine("Adult");
   }
   else if (Age > 60)
   {
       Console.WriteLine("Older");
   }
}
//-------------------------------------------------------------------------------------------


//First-Coding.Challenge==================================================================
//=======================================================================================
//q1.
var e1 = new Employee()
{
   Name = "brijesh",
   Department = "ESS",
   Designation = "trainee"


};
var e2 = new Employee()
{
   Name = "amala",
   Department = "DTS",
   Designation = "senior employee"
};
var e3 = new Employee()
{
   Name = "aiswarya",
   Department = "PES",
   Designation = "manager"

};
Console.WriteLine(e1.Name);
Console.WriteLine(e1.Department);
Console.WriteLine(e1.Designation);
Console.WriteLine(e1.Salary);

//Q3..
var an1 = new Animals()
{
   Name = "cat",
   MaxLife = 13,
   Food = "Fish"

};
an1.showData();

//q4.

var f1 = new Furniture();
var f2 = new Furniture("chair","thekk",2000);

f1.Show();
f2.Show();

q5.
var fd1 = new Food() { 

  Name = "biriyani",
  Price = 200
 

};
fd1.ShowData();

//q6.
var cl1 = new Cloth()
{
   Stock = "new",
   Price = 347,
   Category = "jeans",

};
cl1.StockValue();
cl1.ShowData();

//q7.

var ch1 = new Child()
{
   Name = "amala",
   FamilyName = "karottu",
   Age = 30,
   Occupation = "trainee"
};
ch1.ShowData();


//Q12.
for(int i = 1; i <= 50; i++)
{
   if(i%3==0 && i%5==0)
   {
       Console.WriteLine("FizzBuzz");
   }
   else if (i%3==0)
   {
       Console.WriteLine("Fizz");
   }
   else if (i%5==0)
   {
       Console.WriteLine("Buzz");
   }
   else
   {
       Console.WriteLine(i);
   }
}

//q8.

var pnames = new string[10];
var name = string.Empty;


for (int i = 0; i < pnames.Length; i++)
{
   pnames[i] = Console.ReadLine();
   
}

var temp = "";
for (int i = 0; i < pnames.Length; i++)
{
   for (int j = i+1; j < pnames[i].Length; j++)
   { 
       if(pnames[i][0] > pnames[j][0])
       {
           temp = pnames[j];
           pnames[j] = pnames[i];
           pnames[i]= temp;
       }

   }
}
Console.WriteLine("Ascending order");
foreach (var p in pnames)
{
   Console.WriteLine(p);
}
var temp2 = "";
for(int i = 0; i < pnames.Length; i++)
{
   for(int j = i+1; j < pnames[i].Length; j++)
   {
       if (pnames[i][0] < pnames[j][0])
       {
           temp = pnames[j];
           pnames[j] = pnames[i];
           pnames[i] = temp;
       }
   }
}
Console.WriteLine("Descending order");
foreach(var p in pnames)
{
   Console.WriteLine(p);
 }
var NewPassengerArray = new String[pnames.Length];
Console.Write("Splited Array is  ");
foreach (var item in pnames)
{



       NewPassengerArray = item.Split();
   var FirstName 
       Console.WriteLine(String.Join(", ", NewPassengerArray));
}



Console.WriteLine("Enter the name to be searched");
string SearchName1 = Console.ReadLine();
int count2 = 0;
foreach (string item in NewPassengerArray)
{
   if (item.ToLower() == SearchName1.ToLower())
   {
       //flag = true;
       Console.WriteLine($"{SearchName1} is in the array ");
       count2++;
   }
}
if (count2 == 0)
{
   Console.WriteLine("Item cannot found");
}



//===================c==========================Search
Console.WriteLine("Enter the name to be searched");
string SearchName1 = Console.ReadLine();
var emp1 = new Emp();
emp1.ReadData();
emp1.ShowData();