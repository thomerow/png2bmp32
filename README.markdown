png2bmp32
=========

This program has a single purpose: It converts 32bpp RGBA PNG files to 
32bpp BMP files preserving the alpha channel. 

Motivation
----------

I needed this because the "Windows Ribbon for WinForms"
(see http://windowsribbon.codeplex.com/) only takes BMPs as icons.

The Windows API is not capable of generating BMP images with alpha information and very few graphics 
editing programs are able to preserve transparency when saving images 
as BMP files.