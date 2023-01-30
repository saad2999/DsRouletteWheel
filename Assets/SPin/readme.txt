So to create a new wheel, you just need to use:
  -> SpinWheel wheel = new SpinWheel(int numberOfRewards);
Where "numberOfRewards" its the number of slices you have in your wheel.
Then you just need to set the wheel gameobject in the script by using:
  -> wheel.setWheel(GameObject wheel);
Where "wheel" is the gameobject that you want to spin around.
Done that the is just two more steps first add the callback in:
  -> wheel.AddCallback();
Where the callback one param that is a int which is the index of your reward from 1 to "numberOfRewards"
And finally when you want to spin you use:
  -> StartCoroutine(wheel.StartNewRun());

But do not stop yet, that is basic for you wheel to spin but you can customize the entire wheel:
  -> setSlowingTime(float time) - Its sets the seconds before the wheel stop to slow down.
  -> setMaxTime(float mTime) - The maximum time that the wheel will spin.
  -> setMinTime(float mTime) - The minimum time that the wheel will spin.
  -> setOffset() - Set whenever you wheel stats like   \/  (default) or like this \/ you need to call this.
													  4 | 1                       \1/
													  -----						 4 X 2
													  3 | 2                       /3\
  -> hasOffset() - To check if you have the Offset on default -> false or dont -> true.
  -> RemoveCallback() - Removes the callback.
  -> setVelocity() - Sets the maximum velocity that the wheel will reach before slowing down.