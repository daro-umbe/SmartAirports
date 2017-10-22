package com.bridou_n.beaconscanner.dagger.modules

import android.content.Context

import com.google.firebase.analytics.FirebaseAnalytics

import javax.inject.Singleton

import dagger.Module
import dagger.Provides


@Module
class AnalyticsModule {

    @Provides
    @Singleton
    fun providesFirebaseAnalytics(ctx: Context): FirebaseAnalytics {
        return FirebaseAnalytics.getInstance(ctx)
    }
}
