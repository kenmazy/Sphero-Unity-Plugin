//
//  RKUNBridge.h
//  Unity-iPhone
//
//  Created by Jon Carroll on 6/4/12.
//  Copyright (c) 2012 Orbotix, Inc. All rights reserved.
//

#import <Foundation/Foundation.h>

extern "C" {
    typedef struct RKUNData {
        float pitch;
        float roll;
        float yaw;
        float x;
        float y;
        float z;
        float xPos;
		float yPos;
    } RKUNData;
}


@interface RKUNBridge : NSObject {
    BOOL robotOnline;
    BOOL dataStreamingOn;
    RKUNData lastData;
}

@property (atomic) RKUNData lastData;

+(RKUNBridge*)sharedBridge;

-(void)connectToRobot;
-(BOOL)isRobotOnline;

-(void)enableDataStreaming;
-(void)disableDataStreaming;

@end
