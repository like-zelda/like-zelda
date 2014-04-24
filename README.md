# LikeZelda [![Build Status](https://travis-ci.org/like-zelda/like-zelda.svg)](https://travis-ci.org/like-zelda/like-zelda)

A zelda clone to explore MonoGame capabilities.

Inspired on
[[Speed coding] Zelda: Link's Awakening](https://www.youtube.com/playlist?list=PLD2t5VOqzPm-IwgQwgmXpmLajQlcCwvBD)

## Setup

All the external dependencies (dlls) are in a separate gitmodule. I've tried to
use NuGet but it is not so cross-compatible (VS, MonoDevelop, XamarinStudio).

I'm planning to use `Protobuild.exe` to create the platform-specific solution and
project files when I start to play with cross-platforming.

For now, the instructions are:

    git submodules init
    git submodules update

## Build

    xbuild /t:Build /property:Configuration=Debug LikeZelda.sln

## Clean

    xbuild /t:Clean /property:Configuration=Debug LikeZelda.sln
