   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:PL.ViewPL.View  5      b ^Syncfusion.SfChart.WPF, Version=16.2460.0.50, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89eGclr-namespace:Syncfusion.UI.Xaml.Charts;assembly=Syncfusion.SfChart.WPFSyncfusion.UI.Xaml.Charts 5          PL.View.UserControl1   5      U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:PL.View     5      ` \Syncfusion.Tools.Wpf, Version=16.2460.0.50, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89f bSyncfusion.Shared.MVVM.WPF, Version=16.2460.0.50, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89e	 aSyncfusion.Tools.MVVM.WPF, Version=16.2460.0.50, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89a
 ]Syncfusion.Shared.Wpf, Version=16.2460.0.50, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89g cSyncfusion.PropertyGrid.Wpf, Version=16.2460.0.50, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89` \Syncfusion.Chart.Wpf, Version=16.2460.0.50, Culture=neutral, PublicKeyToken=3d67ed1f87d44c899chart!http://schemas.syncfusion.com/wpf    	 
   5      d
syncfusionGclr-namespace:Syncfusion.UI.Xaml.Charts;assembly=Syncfusion.SfChart.WPF    	 
   5        � DataContext  5         PL.View.MyChart  5   
   .��5      � $	��901��6   $	��563��6   $��Center=�6$   $��Center=�6A   $��-78,-47,-23,-66q�6\   .+�5   
   �� -   5         ��Name$
 root��5      $	��900��6   $	��550��6+   
����������	#FFE6E6E6$
��Left=�6d    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         	Direction$	 181Q�6#      ShadowDepth$ 0Q�63      
BlurRadius$ 15Q�6C      Color$ Black��6S   ._�5      � -   5         �Name$ GridRoot��5       � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $��* �6$   .+�5      �� ���	#FF3A2A48$��0,-1,0,0q�60   $��Center=�6B   ._�5      �� $��Spline��6    $��	10,5,10,5q�6.   
�������$��20(�6T   $��Center=�6b   $��Center=�6}   $��Segoe UI Bold)�6�   5      � 5      $��1��6     5        5      	 � 	Resources	 5!       
  legend
 �� Orientation � ColumnDefinitions  labelTemplate��%�  &	        &	 O    �� 5"      .R�5#      �� $
 
Horizontal=�6)   .+�5$   "   � $��20,0,0,0q�6'    5%   &   �� 5&   *   �� 5'   *   .+�5)   &   �� $��15��60   $��15��6;   ��6G   �� *
Interior+6c   �� 5*   &   $��5,0,0,0q�60   $��16(�6A   $��1��6O   
���   ���6r   �� *Label+6�   5+   #   5,      5-      �� 5.      .R�5/      �� 
���   �$��16(�6Z   ��6(   �� *LabelContent+6Z   50      52      .+�54      '  !Syncfusion.UI.Xaml.Charts.SfChart  -   5          Name$ SplineChart��54   )   $	��450��6>   $	��770��6K   $��22(�6W   
���   �$��Center=�6y   $��87,25,43,39q�6�      	Behaviors 56      4  .Syncfusion.UI.Xaml.Charts.ChartZoomPanBehavior  6@   )  #Syncfusion.UI.Xaml.Charts.ChartBase   Header 58      �� 59      
���   �$��20(�6;   $��Segoe UI)�6I   $��0,0,0,20q�6_   Weather growth6�      PrimaryAxis 5;      ,  &Syncfusion.UI.Xaml.Charts.CategoryAxis  5<      )  #Syncfusion.UI.Xaml.Charts.ChartAxis   
PlotOffset$ 30Q�66      LabelsIntersectAction$
 Auto=�6F      ShowTrackBallInfo .    Header$	 Day��6|   
���   �6�      SecondaryAxis 5>      -  'Syncfusion.UI.Xaml.Charts.NumericalAxis  5?         RangePadding$ Round=�67   $ Temperature��6N   
���   �6c      Series. 5B      ,	  &Syncfusion.UI.Xaml.Charts.SplineSeries	  /
  )Syncfusion.UI.Xaml.Charts.ChartSeriesBase 
  XBindingPath$	 Day��6O   ,  &Syncfusion.UI.Xaml.Charts.XyDataSeries   YBindingPath$
 Temp��6b    
  EnableAnimation .  
  ShowTooltip . ,  &Syncfusion.UI.Xaml.Charts.ChartTooltip   EnableAnimation .  
  ItemsSource 62   �� *Data+/  )Syncfusion.UI.Xaml.Charts.AdornmentSeries   AdornmentsInfo 5C      2  ,Syncfusion.UI.Xaml.Charts.ChartAdornmentInfo  5D   "   6  0Syncfusion.UI.Xaml.Charts.ChartAdornmentInfoBase   Symbol$ Ellipse=�6@      	ShowLabel .     
ShowMarker  . !   LabelTemplate! 5E   &   �� 5F   *   .R�5G   .   � .+�5H   2   A� ���	#FF1BA1E2$��35��6K   $��35��6W   $��0��6b   5I   3   �� 5J   2   
�������$��Segoe UI)�6`   $��14(�6v   $��Center=�6�   $��Center=�6�   ��6<   �� 6�   5K   /   5L   +   5N   #   5P      5Q      5R      5S      5T      5U      5V      