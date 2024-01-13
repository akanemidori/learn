using System.Globalization;

Console.WriteLine("日付を「MM-dd-yyyy」形式で入力してください。");

var inputtext = Console.ReadLine();

var datecheck = DateTime.TryParseExact(inputtext, "MM-dd-yyyy", DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None, out var dt);

if (datecheck)
{
    Console.WriteLine(dt.ToString("変換しました：yyyy/MM/dd"));
}
else
{
    Console.WriteLine("変換できませんでした。");
}

Console.WriteLine("このウィンドウを閉じるには、任意のキーを押してください...");

Console.ReadKey();
