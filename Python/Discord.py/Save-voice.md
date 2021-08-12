# Save voice from voice channel

## Install modified by [Sheepposu](https://github.com/Sheepposu) `discord.py` package using
```shell
pip install git+https://github.com/Sheepposu/discord.py.git
```

## Example python voice recording script

### Simple example to use as separate class
```python
import discord

Sink = discord.Sink

class VoiceInput:
    def __init__(self):
        self.is_recording = False

    def StartRecording(self, vc, time=10):
        filters = {}
        filters.update({'time': time})
        print("Voice input filters: " + str(filters))

        vc.start_recording(Sink(encoding='wav', filters=filters), self.on_stopped)
        self.is_recording = True
        print("Started recording")

    def StopRecording(self, vc):
        if(self.is_recording):
            vc.stop_recording()

    async def on_stopped(self, sink, *args):
        self.is_recording = False
        print("Stopped recording and saved")
```

### Other example is [Sheepposu's](https://github.com/Sheepposu) [receive_vc_audio.py](https://github.com/Sheepposu/discord.py/blob/master/examples/receive_vc_audio.py) script with whole bot structure, commands etc.

## Useful links
* [GitHub - "Sheepposu's discord.py"](https://github.com/Sheepposu/discord.py)
* [GitHub - "Support for receiving audio from voice channels"](https://github.com/Rapptz/discord.py/pull/6507)
* [GitHub - "Sheepposu's receive_vc_audio.py example"](https://github.com/Sheepposu/discord.py/blob/master/examples/receive_vc_audio.py)