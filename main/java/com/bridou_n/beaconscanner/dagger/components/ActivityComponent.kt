package com.bridou_n.beaconscanner.dagger.components

import com.bridou_n.beaconscanner.AppSingleton
import com.bridou_n.beaconscanner.dagger.PerActivity
import com.bridou_n.beaconscanner.dagger.modules.BluetoothModule
import com.bridou_n.beaconscanner.features.beaconList.BeaconListActivity
import com.bridou_n.beaconscanner.features.settings.SettingsActivity

import dagger.Component
import org.altbeacon.beacon.BeaconManager

@PerActivity
@Component(
        dependencies = arrayOf(AppComponent::class),
        modules = arrayOf(BluetoothModule::class)
)
interface ActivityComponent {
    fun providesBeaconManager() : BeaconManager


    fun inject(app: AppSingleton)
    fun inject(activity: BeaconListActivity)
    fun inject(activity: SettingsActivity)
}
