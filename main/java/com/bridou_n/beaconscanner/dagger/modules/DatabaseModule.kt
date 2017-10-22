package com.bridou_n.beaconscanner.dagger.modules

import dagger.Module
import dagger.Provides
import io.realm.Realm

@Module
class DatabaseModule {
    @Provides
    fun providesRealm(): Realm {
        return Realm.getDefaultInstance()
    }
}
