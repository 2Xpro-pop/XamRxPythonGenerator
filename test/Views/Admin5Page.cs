<?xml version="1.0" encoding="utf-8" ?>
<rxui:ReactiveContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:rxui="clr-namespace:ReactiveUI.XamForms;assembly=ReactiveUI.XamForms"
             xmlns:vm="clr-namespace:TestSharp.Hi.ViewModels"
             x:Class="TestSharp.Hi.Views.Admin5Page"
             x:DataType="vm:Admin5ViewModel"
             x:TypeArguments="vm:Admin5ViewModel">
    <ContentPage.Content>
        <StackLayout Padding="25">
            <Text Text="{Binding RxText}"/>
        </StackLayout>
    </ContentPage.Content>
</rxui:ReactiveContentPage>