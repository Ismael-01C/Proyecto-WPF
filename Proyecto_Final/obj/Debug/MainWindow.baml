   M S B A M L   `   `   `  ????I  EProyecto_Final, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Proyecto_FinalProyecto_Final  5   	   M+clr-namespace:Proyecto_Final.MVVM.ViewModelProyecto_Final.MVVM.ViewModel  5   	       Proyecto_Final.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Proyecto_Final     5   	   A	viewModel+clr-namespace:Proyecto_Final.MVVM.ViewModel     5   	   $	??768??5	   	   $
??1366??6     ? WindowStyle$
  None=?5
   	    ? WindowState$ 	Maximized=?5   	    ? 
ResizeMode$ NoResize=?5   	   
??????  ? AllowsTransparency .  ? DataContext 5      1  +Proyecto_Final.MVVM.ViewModel.MainViewModel  5   
   .??5      ?? ??5   
   ?? 5       ?? 
StartPoint$	 0,1&?6"    ?? EndPoint$	 1,3&?63   .??5      ?  ? Color$ #17202A??6    ? Offset$	 0.0Q?6/   ? 5      $ #0f9b0f??6   $ 1Q?6/   5      ._?5!   
   ? 	 ? ColumnDefinitions	 5#      ?? 5$      $	??200 ?6#   ?? 5%      
 ? RowDefinitions
 5(      ?? 5)      $??75 ?6    ?? 5*      .+?5-      ?? $??1??6   $??1??5.      $??10q?5/      ??50      ?? *CurrentView+?? 52      $??Spotify??6   $??Center=?53      $
??Left=?54      
???????$??25(?56      $??82,0,0,0q?57      ?? 58      $??/Images/spotify (1).png??6   $??
-5,8,117,9q?65   ?? 59      $??
1107,0,0,9q?5:      
???  ??
???????
???????$??1,1,1,1q?5>      $??1??5?      ??5@      ?? *ExitCommand+ J? OpacityMask 5A      ?? 5B       ?? ImageSource$ /Images/cancel.png??6!    j? Stretch$ Uniform=?6B   5D      ?? 5H      $??1??6   .+?5K      ??  ?? Orientation$ 
Horizontal=?6   $??82??66   .+?5L      	? 
???????$??60??5M   "   $	??150??5N   "   $??14(?5O   "    d? 	IsChecked$
 TrueY?5P   "      MenuButtonTheme#??[  5Q   "   ??5R   "   ?? *HomeViewCommand+ 5S      ?? 5T      $ /Images/inicio.png??6)   $ Uniform=?6J   5V      5W      ?? 5Z      $ 
Horizontal=?6   $??82??66   .+?5[      	? 
???????$??60??5\   "   $	??150??5]   "   $??14(?5^   "   #??[  5_   "   ??5`   "   ?? *BusquedaArtistaCommand+ 5a      ?? 5b      $ /Images/artista.png??6)   $ Uniform=?6K   5d      5e      ?? 5g      $ 
Horizontal=?6   $??82??66   .+?5h      	? 
???????$??60??5i   "   $	??150??5j   "   $??14(?5k   "   #??[  5l   "   ??5m   "   ?? *BusquedaImagenCommand+ 5n      ?? 5o      $ /Images/imagen.png??6)   $ Uniform=?6J   5q      5r      ?? 5t      $ 
Horizontal=?6   $??82??66   .+?5u      	? 
???????$??60??5v   "   $	??150??5w   "   $??14(?5x   "   #??[  5y   "   ??5z   "   ?? *BusquedaDetallesCommand+ 5{      ?? 5|      $ /Images/detalles.png??6)   $ Uniform=?6L   5~      5      5?      5?      5?      5?      