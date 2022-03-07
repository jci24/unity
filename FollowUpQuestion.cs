using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;


public class VolumeTest
{
    [Test]
    // Start is called before the first frame update
    void Start()
    {
        var audiosource = GetComponent<AudioSource>();
        var expectedVolume = -6;
    }

    // Update is called once per frame
    void Update()
    {
        Assert.That(audiosource.volume, IS.EqualTo(expectedVolume));
    }
}
