   M S B A M L   `   `   `  ���� G  CSports_Store, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Sports_store.ViewsSports_store.Views  A%clr-namespace:Sports_store.ViewModelsSports_store.ViewModels      Sports_store.Views.LogIn   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XRoyWpf.Behaviors.MessengerTrigger, Version=0.1.2.0, Culture=neutral, PublicKeyToken=nullJ FRoyWpf.Packages, Version=0.1.3.0, Culture=neutral, PublicKeyToken=nullK GRoyWpf.Utilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulle aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35L 9http://schemas.microsoft.com/winfx/2006/xaml/presentation        R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     2local clr-namespace:Sports_store.Views     <
viewmodels%clr-namespace:Sports_store.ViewModels     ���#c2c9cc.��� .+��� $	��Top=�$��Right=�  �� Orientation$  
Horizontal=�.+��� $��30��$��30��$��0q����� *Hide+����  �� 
TargetType" ��.���  �� Property � �� �� Value ��  �� 
TargetType" ��.R�� 
���   �.+��� 
�������$��4��$��15��$��Center=��� $��30��$��30��$��0q����� *Exit+���� " ��.���  � �� �� " ��.R�� 
���   �.+�F� 
�������$��4��+����        р�����Ѐ��    �    ���	�� $��Center=�$��Center=�.+���    TextBlockAuth#��[  $��Вход��$��20q�$��Center=��� #��[  $��
Логин����   TextBoxAuth#���  ���� *CurrentLogin+�� ���� *
LoginError+ �� UpdateSourceTrigger$ PropertyChanged=��� #��[  $��Пароль���� #���  ���� *CurrentPassword+�� ���� *PasswordError+$ PropertyChanged=���   BlackWhiteButton#��[ $��	0 20 0 20q�$��
Войти��$��30������ *
GoToMain+�� #��[ $��Регистрация��$��30������ *	GotoReg+