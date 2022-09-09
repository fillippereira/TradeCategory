// See https://aka.ms/new-console-template for more information
using CategorizeTrade.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using TesteGFT.Domain.Entities;
using TesteGFT.Services;


#region DI

var services = new ServiceCollection();
services.AddScoped<ITradeService, TradeService>();
services.AddScoped<ITradeFactory, TradeFactory>();

var serviceProvider = services.BuildServiceProvider();
var tradeService = serviceProvider.GetRequiredService<ITradeService>();
var tradeFactory = serviceProvider.GetRequiredService<ITradeFactory>();

#endregion DI

Console.WriteLine("Insert the data bellow");

var listTrade = new List<Trade>();

string referenceDate = Console.ReadLine();
int portfolioLength = int.Parse(Console.ReadLine());
string[] portifolio = new string[portfolioLength];

for (int i = 0; i < portfolioLength; i++)
{
    portifolio[i] = Console.ReadLine();

    var tradeCategory = tradeService.GetTradeCategory(referenceDate, portifolio[i].Split(" "));

    if(tradeCategory is not null)
        listTrade.Add(tradeFactory.Create((global::TesteGFT.Enum.TradeCategoryEnum)tradeCategory));
}   

foreach(var trade in listTrade)
{
    Console.WriteLine(trade.GetCategory());
}

Console.ReadKey();
