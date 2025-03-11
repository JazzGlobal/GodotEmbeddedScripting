local desiredPosition = CreateVector2(10, 1000)

-- Calculate direction to move
local direction = Vector2Subtract(desiredPosition, Enemy.Position)
direction = Vector2Normalize(direction)

GDPrint("Enemy Position: " .. tostring(Enemy.Position))

-- Check if the two Vector2 instances are equal
if desiredPosition == Enemy.Position then
    GDPrint("The positions are equal")
else
    GDPrint("The positions are not equal")
    -- Move the enemy
    Enemy.Position = Vector2Lerp(Enemy.Position, desiredPosition, .1 * DELTA)
end