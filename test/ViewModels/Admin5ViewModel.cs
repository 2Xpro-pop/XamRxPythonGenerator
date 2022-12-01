using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;
using Xamarin.Forms;

namespace TestSharp.Hi.ViewModels
{
    public class Admin5ViewModel: ReactiveObject
    {
        [Reactive] public string RxText { get; set; }

        public Admin5ViewModel()
        {
            RxText = "Fody & RxUI ♡!"
        }
    }
}
