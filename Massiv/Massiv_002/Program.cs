Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberTxt = Convert.ToString(number);
if (numberTxt.Length > 2){
  Console.WriteLine("третья цифра -> " + numberTxt[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}

