using Mediator.classes;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;

var commandCentre = new CommandCentre();

var runway1 = new Runway(commandCentre);
var runway2 = new Runway(commandCentre);

commandCentre.RegisterRunway(runway1);
commandCentre.RegisterRunway(runway2);

var aircraft1 = new Aircraft("F-16", commandCentre);
var aircraft2 = new Aircraft("Boeing 747", commandCentre);
var aircraft3 = new Aircraft("Airbus A320", commandCentre);

commandCentre.RegisterAircraft(aircraft1);
commandCentre.RegisterAircraft(aircraft2);
commandCentre.RegisterAircraft(aircraft3);

aircraft1.RequestLanding();
aircraft2.RequestLanding();
aircraft3.RequestLanding(); 

aircraft1.TakeOff();
aircraft3.RequestLanding();
