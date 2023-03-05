using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using AssignmentSortech.Dto;
using AssignmentSortech.Service.Interfaces;
using AssignmentSortech.Service.Business;
using AssignmentSortech.View;

public class Program
{
    public static void Main(string[] args)
    {
        var instance =new EventService();
        var events = new EventsView(instance);

        Console.WriteLine("To Create an Event Press Number 1");
        Console.WriteLine("To Get All Events  Press Number 2");
        Console.WriteLine("To Get Event By Id Press Number 3");
        Console.WriteLine("To Remove Event Press Number 4");

        var request=Console.ReadLine();
        switch (request)
        {
            case "1":
                events.createEvent();
                break;
            case "2":
                events.GetAllEvents();
                break;
            case"3":
                events.GetEventById();
                break;
            case "4":
                events.RemoveEvent();
                break;
            default:
                Console.WriteLine("NOT FOUND");
                break;
        } 
    } 
}