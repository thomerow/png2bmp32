png2bmp32
=========

This program has a single purpose: It converts PNG files with alpha channel to 
32bpp BMP files. 

Motivation
----------

I needed this because the "Windows Ribbon for WinForms"
(see http://windowsribbon.codeplex.com/) only takes BMPs as icons.

The Windows API is not capable of generating such images and very few graphics 
editing programs are able to preserve transparency information when saving images 
as BMP files.