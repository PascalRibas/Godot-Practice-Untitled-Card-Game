using Godot;
using System;
//deprecated, will pursue other implementation of effects
public interface OnPlayEffect
{
	public void primaryEffect();
	public void secondaryEffect();
	public String EffectInWords();
}
