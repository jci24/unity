using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.TestTools; 
public class VolumeTarget 
{
    [Test]
    public void CalculateVolumeLevel()
    {
        //ARRANGE
        var snapshot = new AudioMixer();
        var volume = 0;
        var expectedVolume = -6;
        //ACT
        var volume = AudioMixer.GetFloat() //Function that returns the value of the volume of the snapshot
        //ASSERT
         Assert.That(volume, IS.EqualTo(expectedVolume));
    }
}
