   M S B A M L   `   `   `  ����K  GWpfAppCalculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WpfAppCalculatorWpfAppCalculator  5   	   !    WpfAppCalculator.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WpfAppCalculator     5   	     � Title$  
MainWindow��5   	   $	��620��6   $	��480��6)    � 	Resources 5	       �� 
TargetType   btnblack �� Property �� Value  btngrey��%�  &	        &	 �     �� 5
   
   " ��6   .�5      ��  � ��
 �   �6+   �� 5       � ��$ 5q�6'   �� 5       � ��
 �����6+   �� 5       � ��$ 22(�6)   5      �� 5   
   " ��6   .�5      ��  � �� �#58595B6+   �� 5       � ��$ 5q�6'   �� 5       � ��
 �����6+   �� 5       � ��$ 30(�6)   �� 5       � ��$ 0q�60   5      5      .��5      � ���#646464.+�5   
   � $��50q�6   ���#282828 � RowDefinitions 5      �� 5      $��2* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5       $��2* �6    �� 5!      $
��0.2* �6    .+�5%      � $��0��6   .+�5&      �� -   5         ��Name$ Textb��5&   =   $��30q�6   ���#9CB376$��30(�5'       �� Padding$ 15q�6*    �� TextAlignment$ Right=�67   5)      � 5*      $��1��6   $��	20 0 20 0q�6    	 � ColumnDefinitions	 5+      �� 5,      �� 5-      �� 5.      �� 5/      .+�51      � $��0��6   .+�52      �� -   5        
 ��Name$

 BTNC��52   K   #��[  6   $��C��6?   6Y   53      � 54      $��1��6   .+�55      �� -   5        $
 Delete��55   M   #��[  6   $	��DEL��6?   6]   56      � 57      $��2��6   .+�58      �� -   5        $
 Division��58   K   #��[  6   $��/��6?   6]   59      � 5:      $��3��6   .+�5;      �� -   5        $
 Multiplication��5;   K   #��[  6   $��X��6?   6c   5<      5=      � 5?      $��2��6   $��	20 0 20 0q�6    	 5@      �� 5A      �� 5B      �� 5C      �� 5D      .+�5F      � $��0��6   .+�5G      �� -   5        $
 seven��5G   J   #��[ 6   $��7��6>   6Y   5H      � 5I      $��1��6   .+�5J      �� -   5        $
 eight��5J   J   #��[ 6   $��8��6>   6Y   5K      � 5L      $��2��6   .+�5M      �� -   5        $

 nine��5M   J   #��[ 6   $��9��6>   6X   5N      � 5O      $��3��6   .+�5P      �� -	   5        $
 minus��5P   J   #��[ 6   $��-��6>   6Y   5Q      5R      � 5T      $��3��6   $��	20 0 20 0q�6    	 5U      �� 5V      �� 5W      �� 5X      �� 5Y      .+�5[      � $��0��6   .+�5\      �� -
   5        $

 four��5\   J   #��[ 6   $��4��6>   6X   5]      � 5^      $��1��6   .+�5_      �� -   5        $

 five��5_   J   #��[ 6   $��5��6>   6X   5`      � 5a      $��2��6   .+�5b      �� -   5        $	
 six��5b   J   #��[ 6   $��6��6>   6W   5c      � 5d      $��3��6   .+�5e      �� -   5        $

 plus��5e   J   #��[ 6   $��+��6>   6X   5f      5g      � 5i      $��4��6   $��	20 0 20 0q�6    	 5j      �� 5k      �� 5l      .+�5n      � $��0��6    5o      �� 5p      �� 5q      .+�5s      � $��0��6   	 5t      �� 5u      �� 5v      .+�5y      � $��0��6   .+�5z      �� -   5        $	
 one��5z   R   #��[ 6%   $��1��6F   6_   5{      � 5|      $��1��6   .+�5}      �� -   5        $	
 two��5}   R   #��[ 6%   $��2��6F   6_   5~      5      � 5�      $��1��6   .+�5�      �� -   5        $

 zero��5�   !   $��5q�5�   !   ���#58595B$��0��6A   $��40(�6M   
�������5�   /   5�      5�      � 5�      $��1��6   	 5�      �� 5�      �� 5�      .+�5�      � $��0��6    5�      �� 5�      �� 5�      .+�5�      � $��0��6   .+�5�      �� -   5        $
 three��5�   R   #��[ 6%   $��3��6F   6a   5�      � 5�      $��1��6   .+�5�      �� -   5        $
 point��5�   `   #��[ 6%   $��.��6F   $��40(�6R   6o   5�      5�      � 5�      $��1��6   .+�5�      �� -   5        $��equal��5�   [   $��=��6!   $��5q�6-   ���#FF4600$��50(�6M   6h   5�      5�      5�      5�      5�      5�      