   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLPL  5   	   A%clr-namespace:PL.MainWindowViewModel1PL.MainWindowViewModel1  5   	   !clr-namespace:PL.ViewPL.View  5	   	       PL.MainWindow   5   	   U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:PL     5   	   ` \Syncfusion.Tools.Wpf, Version=16.2460.0.50, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89b ^Syncfusion.SfChart.WPF, Version=16.2460.0.50, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89f bSyncfusion.Shared.MVVM.WPF, Version=16.2460.0.50, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89e	 aSyncfusion.Tools.MVVM.WPF, Version=16.2460.0.50, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a
 ]Syncfusion.Shared.Wpf, Version=16.2460.0.50, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89g cSyncfusion.PropertyGrid.Wpf, Version=16.2460.0.50, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89` \Syncfusion.Chart.Wpf, Version=16.2460.0.50, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89>
syncfusion!http://schemas.syncfusion.com/wpf    	 
   5   	   <view%clr-namespace:PL.MainWindowViewModel1    	 
   5   	   -view1clr-namespace:PL.View    	 
   5	   	     � Title$  
MainWindow��5   	   $	��500��6   $
��1000��6)   .��5      � .+�5   
   � $	��450��6   $	��800��6   .+�5      �� -   5         ��Name$ tb��5      $
��Left=�6%   $	��450��6@   $	��800��6M   ���	#FFFDF7F2���	#FF294CC5.@�5      �� -   5         ��Name$ 
CurrentTab��5      $��Current Weather��6.   ���	#FFDA5027���	#FF111111$
��Bold"�6v   .��5         PL.View.Current  $
��Auto��6$   $
��Auto��62   $��10,0,2.4,0.6q�6b    � DataContext 6?   �� *
CurControl+6b   5      �� 5      -   5        $ 	WeeklyTab��5      $��Weekly Weather��6-   ���	#FFDA5027���	#FF161617$
��Bold"�6t   .��5         PL.View.Weekly  $
��Auto��6#   $��10,0,-2.6,-0.4q�6V    60   �� *WeeklyControl+6V   5      �� 5      -   5        $ MapTab��5      $��Weather Map��6*   ���	#FF0A0A0A���	#FFDA5027$
��Bold"�6n   .��5         PL.View.Map  $��0,0,7.4,-0.4q�6C    6    �� *
MapControl+6C   5      �� 5      -   5        $ ChartTab��5      $��Chart��6)   ���	#FFDA5000���	#FF0F0F0F$
��Bold"�6g   .��5         PL.View.WeeklyChart  $��0,0,7.4,-0.4q�6M    6(   �� *ChartControl+6M   5      5      5      5      5      