using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;
using Xamarin.Forms;

namespace TestSharp.Hi.ViewModels
{
    public class adminchickViewModel: ReactiveObject
    {
        [Reactive] public string RxText { get; set; }

        public adminchickViewModel()
        {
            RxText = "Fody & RxUI ♡!"
        }
    }
}
