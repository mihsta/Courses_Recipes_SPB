   M S B A M L   `   `   `  ����I  EWpfApp_Recipes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfApp_RecipesWpfApp_Recipes  5      $    WpfApp_Recipes.PageCurrentDish   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:WpfApp_Recipes     5      -   5          N� Title$  PageCurrentDish��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      6   �� 5      $
��Auto �6   6,   .+�5   
   �� -   5        $��LblCategory��5   -   $��0��6   $��0��6   .��6@   CAT6E   �� 5   
   -   5        $��LblFullTime��5   -   $��1��6   $��0��6   .��6@   TIME6F   �� 5   
   -   5        $��LblTotalCost��5   -   $��1��6   $��1��6   .��6A   COST6G   �� 5   
   $��0��6   $��1��6"    �� Orientation$ 
Horizontal=�62   .+�5      �� .��6   Порций:6   �� 5      -   5         ��Name$ BtnMinus��5      $��25��6>   .��6I   -6L   �� 5      -   5        $��TxtServings��5   !   $��40��6    �� TextAlignment$ Center=�64   6s   �� 5      -   5        $ BtnPlus��5      $��25��6<   .��6G   +6J   5       �� 5"   
   $��2��6   $��0��6!   $��Center=�61   $��18(�6N   Ингредиенты:6j   �� 5#   
   $��2��6   $��1��6!   $��Center=�61   $��18(�6N   Приготовление:6l   &   System.Windows.Controls.DataGrid  5%   
   -   5          Name$ DGridIngredients��5%   0   $��3��6   $��0��6       ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6J      Columns 5&      4  .System.Windows.Controls.DataGridTemplateColumn  5'      	   CellTemplate	 5(      �� 5)      .R�5*      �� $��20��6%   $��20��60   
 �� CornerRadius$
 10��6<   ��5+   "   �� 5,   &    �� 
TargetType" ��6,    �� Triggers 5-   *   �� 5.   .    �� Binding 6:   �� *
IsEnough+ �� Value True6W   .a�5/   2   ��  �� Property � ��   	MainGreen �� Value# [  6O   6t   50   /   �� 51   .    6:   �� *
IsEnough+	 False6W   .a�52   2   ��  � ��  MainRed# [ 6O   6r   53   /   55   '   57      58      5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Header$ Наименование��6%      Width$ 3* 6_   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Ingredient.Name+6l     5<      $ Кол-во��6%    65   �� *TotalQuantity+6Y     5=      $ Ед.изм.��6%    66   �� *Ingredient.Unit.Name+6a     5>      $ Стоимость��6%    68   �� *Sum+ �� StringFormat$ {0:F0} руб.��6n   5@      �� 5B   
   -	   5        $��LViewStages��5B   0   $��3��6   $��1��6    $��Disabled=�6C   ��5C      �� 5D      .R�5E      �� $
��Wrap=�6    $��3q�64   ��5F      `� 5G      $ {0}. {1}��6+   .1�5H   "   ��  �� Path$ OrderNumber�6*   6?   �� 5I   "   $ Description�6*   6?   5J      5L      5M      5O      �� 5Q   
   -
   5        $ BtnStartCooking��5Q   �   $��4��6   $��2��6   $��Center=�62   $��0,10,0,0q�6O   #��[  6a   .��6�   Готовим!6�   5R      5S      