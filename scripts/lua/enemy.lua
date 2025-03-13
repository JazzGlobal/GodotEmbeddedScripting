import 'Godot'


function InitializeState()
    initialized = true
    GDPrint("Enemy initialized")
    desiredX = 1000;
    maxX = 1000;
    minX = 100;
    tolerance = 10.0;
    step = 3;

    local x = Vector2(100, 20);
    GDPrint(tostring(x));
end


function ProcessState(delta)
    local fired = false;
    local desiredPosition = CreateVector2(desiredX, 20)    
    local distance = Vector2Distance(desiredPosition, Enemy.Position)
    if distance <= tolerance then
        if desiredX == maxX then
            desiredX = minX
            if not fired then
                Enemy:FireBullet(-1, -1)
                fired = true
            end
        else
            desiredX = maxX
            if not fired then
                Enemy:FireBullet(-1, 0)
                fired = true
            end
        end
    else
        -- Move the enemy
        Enemy.Position = Vector2Lerp(Enemy.Position, desiredPosition, step * delta)
    end
end

