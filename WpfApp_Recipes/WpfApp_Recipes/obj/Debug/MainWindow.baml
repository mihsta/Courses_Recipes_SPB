   M S B A M L   `   `   `  ����I  EWpfApp_Recipes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfApp_RecipesWpfApp_Recipes  5   	       WpfApp_Recipes.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WpfApp_Recipes     5   	     � Title$  Мои рецепты��5   	    � Icon$ Resources/soup.ico��6   $	��700��67   $
��1000��6D   $	��400��6Q   $	��800��6a    � WindowStartupLocation$ CenterScreen=�6p   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��150 �6   6-   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��40 �6   6*   �� 5      6   .+�5   
   �� $��1��6   $��24(�6_   $
��10,0q�6m   $��Center=�6{   ��6$   ��  �� ElementName$ 	MainFrame�� �� Path$ Content.Title�6�   �� 5   
   $��2��6      	MainGreen#��[  6&    �� Orientation$ Vertical=�6N   .+�5      �� $��Resources/soup.png��6   $��10q�60   6>   �� 5      -   5        $��	BtnDishes��5      $
��Auto��6>     
MainYellow#��[ 6K   .��6t   
Блюда6{   �� 5      -   5        $��BtnIngredients��5      $
��Auto��6H   #��[ 6U   .��6~   Ингредиенты6�   5       � 5   
   -   5        $��	MainFrame��5   9   $��10q�6   $��1��6   $��1��6)     � NavigationUIVisibility$ Hidden=�6J   6l   5      5      