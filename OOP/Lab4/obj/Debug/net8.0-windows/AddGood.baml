   M S B A M L   `   `   `  ����?  ;Lab4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab4Lab4  5      \ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35P<clr-namespace:Microsoft.Win32;assembly=PresentationFrameworkMicrosoft.Win32 6(       Lab4.AddGood   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      $localclr-namespace:Lab4     5      Nwin32<clr-namespace:Microsoft.Win32;assembly=PresentationFramework     6(   .��5
      �    	GridTheme#���   6     � ColumnDefinitions  5   
   �� 5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��0.4* �6   .+�5   
   �� $
��Auto=�6   .��5      �� $��0��6   $��0��6&   $��20q�66    � 	Resources 5       �� 
TargetType �� Property �� Value  rate �� Triggers �� Binding �� Value 	 price  fullname  	shortname  description��%�  '��       &	 p     &	 <    &	     &	 �    &	 �    �� 5      " ��6   .�5      ��  � ��$ 20(�65   �� 5       � ��$ Roboto)�67   5      �� 5      " ��6)    5      �� 5       6*   �� *CreatingGood.IsRatingGood+	 False6X   .a�5   "   ��  � ��$ 1q�6D   �� 5   "    � ��
 �  ��6@   5      5       �� 5!      " ��6*    5"      �� 5#       6*   �� *CreatingGood.IsPriceGood+	 False6W   .a�5$   "   ��  � ��$ 1q�6D   �� 5%   "    � ��
 �  ��6@   5&      5(      �� 5)      " ��6-    5*      �� 5+       6*   �� *CreatingGood.IsFullNameGood+	 False6Z   .a�5,   "   ��  � ��$ 1q�6D   �� 5-   "    � ��
 �  ��6@   5.      50      �� 51      " ��6.    52      �� 53       6*   �� *CreatingGood.IsShortNameGood+	 False6[   .a�54   "   ��  � ��$ 1q�6D   �� 55   "    � ��
 �  ��6@   56      58      �� 59      " ��60    5:      �� 5;       6*   �� * CreatingGood.IsDescriptionGood+	 False6]   .a�5<   "   ��  � ��$ 1q�6D   �� 5=   "    � ��
 �  ��6@   5>      5@      5A      .+�5B      ��   AddingT#���  6   �� 5C       	 NameT#���  6   �� 5D      #��[ 6A   ��6   �� *CreatingGood.FullName+6A   �� 5E        
ShortNameT#���  6   �� 5F      #��[ 6B   ��6   �� *CreatingGood.ShortName+6B   �� 5G       	 DescriptionT#��� 	 6   �� 5H      #��[ 6D   ��6   �� *CreatingGood.Description+6D   �� 5I       
 RatingT#��� 
 6   �� 5J      #��[ 6?   ��6   �� *CreatingGood.Rating+6?   �� 5K       
 PriceT#���  6   �� 5L      #��[ 6>   ��6   �� *CreatingGood.Price+6>   �� 5M        
AvailableT#���  6   �� 5N      	 d� 	IsChecked	 6   �� *CreatingGood.IsAvailableBool+
 �� Mode$
 TwoWay=��� 5O       
 ImageT#���  6   �� 5P      
�������  ChooseT#���  6I   
���   ���6   �� *
AddImage+6m   �� 5Q        	CategoryT#���  6   �� 5R      -   5         ��Name$ Combo��5R       �� SelectedItem 6*   �� *CreatingGood.Category+�� 5S       
 ColorT#���  6   �� 5T      -   5        $ Color��5T       6*   �� *CreatingGood.Color+�� 5U        AddT#���  68   $��0, 20, 0, 20q�6Y   
���   �
���������6   �� *
CreateGood+6�   5V      5W      �� 5X   
   $��0��6   $��1��6    $��15q�6S   ��6-   �� *CreatingGood.Image+6S   5Y      5Z      