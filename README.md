# GraphyTest

A test framework for generating framerate spikes

This project contains a single scene file.

To configure the base CPU time per frame, edit the `CPU Load` script on the `Camera`. This has two values, the minimum frametime and the mean frametime. The mean time has to be greater than the minimum time. The amount time per frame is the minimum time plus a random extra amount from a Poisson distribution. This appears to emulate frame times from captures reasonably well.

To configure the spikes, edit the `Spike` script on the `Camera`. For each spike you can set the period in seconds, the delay until the first spike in seconds, and the spike duration in milliseconds. You can set as many spikes as you like.

![screen grab](ScreenGrab.png)
