# Make ffmpeg ignore bitrate warning

## Error
![screenshot_ffmpeg_warning](../../screenshots/screenshot_ffmpeg_warning.png)
### This warning can be ignored and it won't affect your program

## Fix
### This ffmpeg arguments allows you to hide this type of warnings
```shell
ffmpeg -loglevel error
```

### So when playing audio in your discord bot you can use this argument
```python
discord.FFmpegPCMAudio(options = "-loglevel error")
```
### Example
```python
voice_channel.play(discord.FFmpegPCMAudio('audio.mp3', options = "-loglevel error"), after=lambda e: print('Player error: %s' % e) if e else print('Played audio.mp3'))
```

## Useful links
* [Super User - "How can I make ffmpeg be quieter/less verbose?"](https://superuser.com/questions/326629/how-can-i-make-ffmpeg-be-quieter-less-verbose)
* [Stack Overflow - "discord.py [mp3 @ 000001dc99bec540] Estimating duration from bitrate, this may be inaccurate"](https://stackoverflow.com/questions/62223370/discord-py-mp3-000001dc99bec540-estimating-duration-from-bitrate-this-may-b)