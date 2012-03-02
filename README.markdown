png2bmp32
=========

This program has a single purpose: It converts PNG files with an alpha channel to 
32bpp BMP files. 

Motivation
----------

I needed this because the "Windows Ribbon for WinForms"
(see http://windowsribbon.codeplex.com/) only takes BMPs as icons.

The Windows API is not capable of generating BMP images with alpha information and very few graphics 
editing programs are able to preserve transparency when saving images 
as BMP files.