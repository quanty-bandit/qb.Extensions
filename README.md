# qb.Extensions
Unity class extensions.

In general each extension is define in a specific namespace formated as:

**Extensions.\<<i>the name of the extented class</i>>_\<<i>the name of the method</i>>**

## CONTENT

### AudioMixer
**string[] AudioMixer.GetExposedParameterNames()** 

>Returns the exposed parameters names from an AudioMixer.
### Awaitable
**async Task Awaitable.AsTask()**

>Converts an Awaitable to a Task, enabling use with async/await patterns.

**async Task\<T> Awaitable\<T>.AsTask()**

>Converts an Awaitable to a Task, enabling use with async/await patterns.

**Awaitable Awaitable.WaitUntil(this Func<bool> condition, int pollIntervalMs = 33)**
>Repeatedly polls a condition until it returns true.
>
>Code source from adammyhre:  https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/AwaitableExtensions.cs
### Camera
**float Camera.FocusMinDistance(float radius, bool useHorizontalFov = false)**
>Gets the minimum distance from the camera to view a circular area with the best fit.

**Vector3 Camera.FocusPosition(Vector3 center, float radius,bool useHorizontalFov=false)**
>Gets the position of the camera to view a circular area, placed on center position, with the best fit.  

**Camera.FocusOn(Vector3 center, float radius, bool useHorizontalFov= false)**
>Sets the camera position and near plane to focus to a circular zone
### Color
**Color Color.Add(Color otherColor)**
>Adds the RGBA components of two colors and clamps the result between 0 and 1.

**Color Color.Blend(Color color2, float ratio)**
>Returns a new color resulting of the blend with an othe color from a specified ratio.

**Color Color.Clamp01()**
>Returns a new color with each component clamped between 0 and 1.

**Color Color.Clone()**
>Creates a new Color instance with the same component values as the specified Color.

**Color Color.Complementary()**
>Returns a new color filled with the complementaries values from the source color.

**Color Color.Contrast(bool _preserveOpacity=true)**
>Returns a new contrasted color from the source.

**Color Color.Invert()**
>Returns a new inverted color.

**Color Color.Subtract(Color otherColor)**
>Returns the clamped result between 0 and 1 of the color substraction from the RGBA components.

**string Color.ToHex()**
>Returns the hexadicimal string of the color

### GameObject

**Bounds GameObject.GetBoundsWithChildren(bool includeInactive=false)**
>Returns the global bounds of a rendered game object and its children.   

**T[] GameObject.GetComponentsFromDescendants\<T>(bool reccursive = true)**
>Returns an array of components from all descendants of a game object or null if no component was founded.

**T[] GameObject.GetComponentsFromRootAndDescendants\<T>(bool reccursive = true)**
>Returns an array of components from a game object and its descendants or null if no component was founded.

**GameObject GameObject.GetFirstDescendantWithTag(string tag)**
>Returns the first desendant from a game object with a sopecific tag or nul if nothing found.

**I[] GameObject.GetInterfacesFromDescendants\<I>(bool reccursive = true)**
>Returns an array of interfaces from game object descendants or null if nothing was found. 

**GameObject.GameGetInterfacesFromDescendants\<I>(List\<I> interfaces)**
>Fills the interface provided list with interfaces found in all descendants reccursively

**GameObject.GetInterfacesFromChildren\<I>(List\<I> interfaces)**
>Fills the interface provided list with interfaces found in the children.

**GameObject.GetInterfacesFromMonoBehaviours\<I>(List\<I> result)**
>Fills the interface provided list with interfaces found in the game object Monobehaviours

**I[] GameObject.GetInterfacesFromRootAndDescendants\<I>(bool reccursive = true)**
>Returns an array of interfaces from the game object and its descendants or null if nothing was found.

**bool GameObject.IsInPersistentBranch()**
> Check if a game object is persistent or belongs to hierachy where the root is persistent which means it won't be destroyed despide the scene loading process.

**T GameObject.ReccursiveGetFirstComponent\<T>()**
>Returns the first component from type from a game object and its descendants.

### IEnumerable

**IEnumerable.DoActionOnEach\<T>(Action\<T> action)**
>Performs an action on each element in the sequence.
>
>Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/EnumerableExtensions.cs

**T IEnumerable.GetAtRandom\<T>()**
>Returns a random element from the sequence.
>
>Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/EnumerableExtensions.cs

### IList

**IList\<T> IList.Filter\<T>(Predicate\<T> predicate)**
>Filters a collection based on a predicate and returns a new list containing the elements that match the specified condition.

**IList.Shuffle\<T>()**
>Shuffle all the elements in the list

**IList.Swap\<T>(int indexA, int indexB)
>Swaps two elements in the list at the specified indices.

### Image
**Image.SetSprite(Sprite sprite,bool alignPivots=true)**
>Sets the image sprite and align its pivot if required

### LayerMask
**bool LayerMask.Contains(int layerNumber)**
>Checks if LayerMask contains a layer.

### List
**List\<T> List.Clone\<T>()**
>Creates a new list that is a copy of the original list.

### Material

**MaterialShaderParameter[] Material.GetParameters()**
>Gets an array of the material shader parameters

**Material.SetParameters(params MaterialShaderParameter[] parameters)**
>Sets materials parameters using MaterialShaderParameter objects

### Math
**float float.Remap(float valueRangeMin, float valueRangeMax,float newRangeMin, float newRangeMax)**
>Remaps a float value from a source interval to a new one

**double double.Remap(double valueRangeMin, double valueRangeMax, double newRangeMin, double newRangeMax)**
>Remaps a double value from a source interval to a new one

**int int.Remap(int valueRangeMin, int valueRangeMax, int newRangeMin, int newRangeMax)**
>Remaps an int value from a source interval to a new one

### MethodInfo
**MethodInfo.IsOverride()**
>Checks if a method is an override

### PolygonCollider2D
**PolygonCollider2D.UpdateShapeFromSprite(Sprite sprite)**
**PolygonCollider2D.UpdateShapeFromSprite(SpriteRenderer spriteRenderer)**
**PolygonCollider2D.UpdateShapeFromSprite()**
>Updates physics shape from sprite 

### RectTransform
**Vector2 RectTransform.GetAnchoredPositionFrom(RectTransform newOrigin)**
>Gets the anchored position from an other origin 

**Canvas RectTransform.GetCanvas()**
>Gets the recttransform canvas

**Rect RectTransform.GetWorldRect()**
>Gets RectTransform.rect's local coordinates to world space rect

**Rect RectTransform.GetWorldRect(Vector2 scale)**
>Gets RectTransform.rect's local coordinates to scaled world space rect

**Vector2 RectTransform.ScreenPointToScreenUV(Vector2 position, Camera camera)**
>Converts a screen point in screen uv.
>
>Set the camera to null if canvas mode is screen space

**Vector2 RectTransform.ScreenPointToScreenUV(Vector2 position)**
>Converts a screen point in screen uv for canvas with mode set to screen space.

**Vector2 RectTransform.ScreenPosition(Camera camera)**
>Gets the position from screen coordonates.

**Rect RectTransform.ScreenSpaceRect()**
>Gets the rect from screen coordonates.

### Reflexion
Integration of adammyhre utility code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/ReflectionExtensions.cs

### Renderer
**Renderer.DisableZWrite()**
>Disables ZWrite for materials in this Renderer that have a '_Color' property. 
This would stop  the materials from writing to the Z buffer, which may be desirable in some cases to prevent subsequent 
rendering from being occluded, like in rendering of semi-transparent or layered objects.
>
>Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/RendererExtensions.cs

**Renderer.EnableZWrite()**
>Enables ZWrite for materials in this Renderer that have a '_Color' property. This will allow the materials 
to write to the Z buffer, which could be used to affect how subsequent rendering is handled, 
for instance, ensuring correct layering of transparent objects.
>
>Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/RendererExtensions.cs

### Rigidbody
**Rigidbody Rigidbody.ChangeDirection(Vector3 direction)**
>Changes the direction of the Rigidbody's velocity while maintaining its speed.
>
>Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/RigidbodyExtensions.cs

**Rigidbody Rigidbody.Stop()**
>Stops the Rigidbody by setting its linear and angular velocities to zero.
>
>Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/RigidbodyExtensions.cs

### Sprite
**Vector2 Sprite.GetPhysicsShapeTotalSize()**
>Returns the physics shape total size

**Sprite.GetPhysicsShapeTotalSizeAndCenter(out Vector2 size, out Vector2 center)**
>Returns the physics shape total size and the center

