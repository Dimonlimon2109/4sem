   M S B A M L   `   `   `  ����G  CSports_Store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Sports_store.ViewsSports_store.Views  5      A%clr-namespace:Sports_store.ViewModelsSports_store.ViewModels  5          Sports_store.Views.LogIn   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XRoyWpf.Behaviors.MessengerTrigger, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:Sports_store.Views     5      <
viewmodels%clr-namespace:Sports_store.ViewModels     5      ���#c2c9cc.��5      � .+�5   
   �� $	��Top=�6   $��Right=�6-     �� Orientation$  
Horizontal=�6I   .+�5      �� $��30��6   $��30��6    $��0q�6,   ��6@   �� *Hide+��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value 5      �� 5   "    �� 
TargetType" ��62   .R�5   &   � 
���   �.+�5   *   �� 
�������$��4��6A   $��15��6L   $��Center=�6W   5   '   5   #   5      5      5      �� 5      $��30��6   $��30��6    $��0q�6,   ��6@   �� *Exit+��5      �� 5      " ��6   .�5      ��  � �� 5       �� 5!   "   " ��62   .R�5"   &   � 
���   �.+�5#   *   F� 
�������$��4��6>   +����        р�����Ѐ��    �    ���	6R   5$   '   5%   #   5'      5(      5*      5+      �� 5,   
   $��Center=�6   $��Center=�62   .+�5-      ��    TextBlockAuth#��[  6   $��Вход��68   $��20q�6D   $��Center=�6P   6o   �� 5.   
   #��[  6   $��
Логин��6;   6J   �� 5/   
     TextBoxAuth#���  6   ��68   �� *CurrentLogin+6X   �� 50   
   ��6   �� *
LoginError+ �� UpdateSourceTrigger$ PropertyChanged=�6W   �� 51   
   #��[  6   $��Пароль��6;   6K   �� 52   
   #���  6   ��68   �� *CurrentPassword+6[   �� 53   
   ��6   �� *PasswordError+$ PropertyChanged=�6Z   �� 54        BlackWhiteButton#��[ 6   $��	0 20 0 20q�6@   $��
Войти��6p   $��30��6�   ��6S   �� *
GoToMain+55      �� 56      #��[ 6   $��Регистрация��6[   $��30��6q   ��6?   �� *	GotoReg+57      58      59      5:      