using System;
using Microsoft.Extensions.DependencyInjection;

namespace Module3HW2
{
    public class StartUp
    {
        public void Run()
        {
            var serviceProvider = new ServiceCollection()
                .AddTransient<INewList<string, Contact>, NewList<string, Contact>>()
                .AddTransient<IContactListView<string, Contact>, ContactListView<string, Contact>>()
                .AddTransient<IGroupContactsService<Contact>, GroupContact<Contact>>()
                .AddTransient<TestApp>()
                .BuildServiceProvider();

            var start = serviceProvider.GetService<TestApp>();
            start.Run();
        }
    }
}