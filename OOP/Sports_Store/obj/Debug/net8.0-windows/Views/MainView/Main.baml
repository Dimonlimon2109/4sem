   M S B A M L   `   `   `  ����G  CSports_Store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Sports_storeSports_store  5   	   A%clr-namespace:Sports_store.ViewModelsSports_store.ViewModels  5   	   \ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35ZAclr-namespace:System.Windows.Shell;assembly=PresentationFrameworkSystem.Windows.Shell 5   	       Sports_store.Main   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XRoyWpf.Behaviors.MessengerTrigger, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Sports_store     5   	   <
viewmodels%clr-namespace:Sports_store.ViewModels     5   	   SshellAclr-namespace:System.Windows.Shell;assembly=PresentationFramework     5   	   _	 [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aW
 SSystem.Windows.Interactivity, Version=0.1.2.0, Culture=neutral, PublicKeyToken=null5i+http://schemas.microsoft.com/xaml/behaviors 	 
 6Y     � Title$
  Main��5
   	   $	��700��6   $
��1000��6#   
������� � 
ResizeMode$ NoResize=�6J    � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 none=�6*    � DataContext 5      $   Sports_store.ViewModels.MainVM  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $	��Top=�6.   
�������.+�5      �� $2��,pack://application:,,,/Resources/profile.png��6   $��50 0 0 0q�6J   $��70��6\   $��70��6h   * 	 $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      + 	 %Microsoft.Xaml.Behaviors.EventTrigger  5         	EventName$ 	MouseDown��6%   * 	 $Microsoft.Xaml.Behaviors.TriggerBase	   Actions.	 5      2 	 ,Microsoft.Xaml.Behaviors.InvokeCommandAction  
   CommandParameter$
 Profile��6O      Command 60   �� *
ChangePage+6O   5      5      �� 5      $
��Bold"�6   $��Roboto)�6*   $��40(�6>   $��Center=�6L   $��Каталог��6g   $��200 0 200 0q�6v    5   "     5      $ 	MouseDown��6%   .	 5         $
 Catalog��6O    60   �� *
ChangePage+6O   5!      5#      �� 5$      $/��)pack://application:,,,/Resources/plus.png��6   $��0 0 20 0q�6G   $��60��6Y   $��60��6e   ��5%      �� 5&       �� 
TargetType" ��6   .�5'      ��  �� Property � y� �� Value$ Visible=�67    �� Triggers 5(      �� 5)       �� Binding 6*   �� *CurrentUser.IsAdmin+ �� Value 06R   .a�5*   "   ��  � y�$ Hidden=�6?   5+      5-       5/        50      $ 	MouseDown��6%   .	 51         60   �� *
AddNewGood+52      54      �� 55      $/��)pack://application:,,,/Resources/cart.png��6   $��70��6G   $��70��6S   $��0 0 0 0q�6^   ��56      �� 57      " ��6   .�58      ��  � y�$ Visible=�67    59      �� 5:       6*   �� *CurrentUser.IsAdmin+ 16R   .a�5;   "   ��  � y�$ Hidden=�6?   5<      5>       5@        5A      $ 	MouseDown��6%   .	 5B        $
 Basket��6O    60   �� *
ChangePage+6O   5C      5E      �� 5F      $	��Top=�6   $��Right=�61   $��113.5 0 0 49.7q�6M   $ 
Horizontal=�6e   .+�5G      �� $��30��6   $��30��6$   $��0q�60   ��6D   �� *Hide+��5H      �� 5I      " ��6    .�5J      ��  � �� 5K   "   �� 5L   &    �� 
TargetType" ��66   .R�5M   *   � 
�������.+�5N   .   �� 
���   �$��4��6E   $��15��6P   $��Center=�6[   5O   +   5P   '   5R      5S      5U      �� 5V      $��30��6   $��30��6$   $��0q�60   ��6D   �� *Exit+��5W      �� 5X      " ��6    .�5Y      ��  � �� 5Z   "   �� 5[   &   " ��66   .R�5\   *   � 
�������.+�5]   .   F� 
���   �$��4��6B   +����        р�����Ѐ��    �    ���	6V   5^   +   5_   '   5a      5b      5d      5e      5f      �� 5g   
   $��1��6   ��6&   �� *CurrentUserControl+5h      5i      