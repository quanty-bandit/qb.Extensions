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


**GameObject.OnEveryChild(System.Action\<GameObject> action,bool occursOnAllDescendants=false)**
>Executes a specified action for each child of a given GameObject.<br>
>This method iterates over all child and executes a given action on them.<br>
>By default the action is executed only on the direct children, to apply the action on all the descendants in the hierarchy set the occursOnAllDescendants to true.<br>
The action is a delegate that takes the child GameObject as parameter.


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
**PolygonCollider2D.UpdateShapeFromSprite(Sprite sprite)**<br>
**PolygonCollider2D.UpdateShapeFromSprite(SpriteRenderer spriteRenderer)**<br>
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

### string
**string string.AddSpaceBeforeCapital()**
>Add a one space before each capital after the first charater of the string 

**string string.FoldToASCII(int? length = null)**
>Converts alphabetic, numeric, and symbolic Unicode characters
which are not in the first 127 ASCII characters (the "Basic Latin" Unicode block)
into their ASCII equivalents, if one exists.
>
>Source code from: https://gist.github.com/andyraddatz/e6a396fb91856174d4e3f1bf2e10951c

**string string.FormatForValidEnumName()**
>Returns a formatted string valid to be an enum name by removing first and last spaces, invalid characters and replace spaces and - by _

**string string.FormatForValidFileName(string spaceReplaceString="-")**
>Formats the string by removing first and last spaces, replaces spaces by the specified spaceReplaceString and removes invalid characters 

**int[] string.GetUnicodeValues()**
>Returns the uft32 characters string values.

**bool string.IsBlank()**
>Checks if a string contains null, empty or white space.

**bool string.IsNullOrEmpty()**
**bool string.IsNullOrWhiteSpace()**

**string string.RemoveHtmlTag(params string[] tags)**
>Returns a new string with specified html tags removed

**string string.RemoveHtmlTagAndContent(params string[] tags)**
>Returns a new string with specified html tag and text inside removed

**string string.ReplaceAt(int index, int length, string replace)**
>Returns a new string with the substring replacement at index.

**string string.ReplaceEachCharByPattern(int index, int length, string replacePattern)**
>Returns a new string with a part filled by a string pattern

**string string.RichColor(string htmlHexColor)**
>Returns the string framed with the color richtext tag 

**string string.RichSize(int size)**
>Returns the string framed with the size richtext tag 

**string string.RichBold()**
>Returns the string framed with the bold richtext  tag

**string string.RichItalic()**
>Returns the string framed with the italic richtext tag

**string string.RichUnderline()**
>Returns the string framed with the underline richtext tag

**string string.RichStrikethrough()**
>Returns the string framed with the strikethrough richtext tag

**string string.RichFont(string font)**
>Returns the string framed with the richFont richtext tag

**string string.RichAlign(string align)**
>Returns the string framed with the align richtext tag

**string string.RichGradient(string htmlHexStartColor, string htmlHexEndColor)**
>Returns the string framed with the gradient color richtext tag

**string string.RichRotation(float angle)**
>Returns the string framed with the rotation color richtext tag

**string string.RichSpace(float space)**
>Returns the string framed with the rotation space richtext tag

**string string.Scramble(string seed, int offset=0)**
>Returns a scramble string from a string seed and offset

**string string.Unscramble(string seed, int offset=0)**
>Returns an unscramble string previously scrambled

**string string.Shorten(int maxLength)**
>Shortens a string to the specified maximum length. If the string's length is less than the maxLength, the original string is returned.

**string string.Slice(int startIndex, int endIndex)**
>Slices a string from the start index to the end index.

**string StringUtility.ConvertUtf32(params int[] unicodeValues)**<br>
**string StringUtility.ConvertUtf32(IEnumerable\<int> unicodeValues)**
>Converts unicodes utf32 characters to a string

### Texture2D
**Sprite Texture2D.ToSprite(Vector2 pivot, float pixelPerUnit = 100f)**<br>
**Sprite Texture2D.ToSprite(SpriteAlignment pivotPosition= SpriteAlignment.Center,float pixelPerUnit = 100f)**
>Returns a sprite from the texture 

### Transform
**Transform.DestroyChildren(float delay=0)**
>Destroy all children after the delay expiration

**Transform.DestroyImmediateChildren(float delay=0)**
>Destroy all children

**Transform Transform.FindFirstDescendantFromName(string name, bool parseAllDescendants=true)**
>Returns the first found descendant which name matchs with the seeked name or null if nothing found.<br>
>The search can be performed throw all the descendants hierarchy if the parameter parseAllDescendants is set to true.<br>
>The research process analyzes each hierarchical level before moving on to the next level in the order of the children.

**Transform Transform.FindDescendantFromPath(string path,string nodeStringSeparator="/")
>Searches for a descendant node reccursively from a string pathNodesNames like a file pathNodesNames

**Transform[] Transform.FindDescendants(Regex nameRegex,bool parseAllDescendants = true)**
>Searches for descendant nodes whose names match the regular expression parameter.<br>
>The search can be performed throw all the descendants hierarchy if the parameter parseAllDescendants is set to true.<br>
>In case of nothing found the Transform array would be empty.

**Transform[] Transform.FindDescendants(string name, bool parseAllDescendants = true)**
>Searches for descendant nodes whose names matche the name parameter<br>
>The search can be performed throw all the descendants hierarchy if the parameter parseAllDescendants is set to true.<br>
>In case of nothing found the Transform array would be empty.

**Transform.ReccursiveFindDescendants(Regex nameRegex, List\<Transform> result)**
>Appends to result list the found descendants whose names match the regular expression parameter.

**Transform.FindChildren(Regex nameRegex, List\<Transform> result)**
>Appends to result list the found direct children whose names match the regular expression parameter.

**int[] Transform.GetDescendantIndexPath(Transform descendantTarget)**
>Returns the descendant index array path from the root target to the descendant 
or null if the descendant target doesn't belong to the root hierachy. 

**Transform Transform.GetDescendantFromIndexPath(params int[] descendantIndexes)**
>Returns the descendant from self hierarchy using descendant indexes or null if the indexation is wrong.

**Transform[] Transform.GetDescendants()**
>Returns all descendants.

**Transform.GetDescendants(List\<Transform> descendants)**
>Appends the descendants list with all descendants nodes.

**bool Transform.InRangeOf(Transform target, float maxDistance, float maxAngle = 360f)**
>Checks if the transform is within a certain distance and optionally within a certain angle (FOV) from the target transform.<br>
Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/TransformExtensions.cs

**string  Transform.Path(string pathNodeSeparator="/")**
> Returns the transform composed names path from self node to parent root.<br>
In case of the self node is a root node the self node name is returned.

**Transform.Reset()**
>Resets transform's position, scale and rotation.

**Transform.RotateAround(Vector3 pivot,Quaternion rotation)**
**Transform.RotateAround(Vector3 pivot,Vector3 eulerAngles)**
>Rotates around a pivot point.


**Transform.OnEveryChild(System.Action\<Transform> action, bool occursOnAllDescendants = false)**
>Executes a specified action for each child of a given Transform.<br>
>This method iterates over all child and executes a given action on them.<br>
>By default the action is executed only on the direct children, to apply the action on all the descendants in the hierarchy set the occursOnAllDescendants to true.<br>
The action is a delegate that takes the child Transform as parameter.

### Vector2
**Vector2 Vector2.Add(float x = 0, float y = 0)**
>Adds to any x y values of a Vector2<br>
Source code: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/Vector2Extensions.cs

**bool Vector2.InRangeOf(Vector2 target, float range)**
>Checks if the current Vector2 is in a given range from another vector<br>
>Source code: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/Vector2Extensions.cs

**Vector2 Vector2.Quantize(Vector2 quantization)**
**Vector2 Vector2.Quantize(float qx, float qy, float qz)**
>Rounds the components of a Vector2 down to the nearest multiple of the given quantization step.
Source cde from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/Vector3Extensions.cs


**Vector2 Vector2.RandomPointOnRing(float minRadius, float maxRadius)**
>Computes a random point in an annulus (a ring-shaped area) based on minimum and 
maximum radius values around a central Vector2 point (origin).<br>
Source code: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/Vector2Extensions.cs

**Vector2 Vector2.With(float? x = null, float? y = null)**
>Sets any x y values of a Vector2<br>
Source code: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/Vector2Extensions.cs

### Vector3
**Vector3 Vector3.Add(float x = 0, float y = 0, float z = 0)**
>Adds to any x y z values of a Vector3<br>
Source code: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/Vector3Extensions.cs

**Vector3 Vector3.ComponentDivideIfNotZero(Vector3 div)**
>>Divides two Vector3 objects component-wise.<br>
>>For each component in v0 (x, y, z), it is divided by the corresponding component in v1 if the component in v1 is not zero. 
Otherwise, the component in v0 remains unchanged.<br>
Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/Vector3Extensions.cs

**bool Vector3.InRangeOf(Vector3 target, float range)**
>Checks if the current Vector2 is in a given range from another vector<br>
>Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/Vector3Extensions.cs

**Vector3 Vector3.Quantize(Vector3 quantization)**
**Vector3 Vector3.Quantize(float qx, float qy, float qz)**
>Rounds the components of a Vector3 down to the nearest multiple of the given quantization step.
This is useful for reducing precision or snapping positions to a grid,<br>
for example to limit NavMesh rebuilds or discretize movement updates.<br>
Source cde from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/Vector3Extensions.cs

**Vector3 Vector3.RandomPointOnPlaneRing(float minRadius, float maxRadius, Vector3 planeNormal)**
>Gets a random point in an annulus (a ring-shaped area) based on minimum and maximum radius values around a central Vector3 point (origin) on a specified plane.

**Vector3 Vector3.RandomPointOnXYPlaneRing(float minRadius, float maxRadius)**
>Gets a random point in an annulus (a ring-shaped area) based on minimum and maximum radius values around a central Vector3 point (origin) on a the xy plane.

**Vector3 Vector3.RandomPointOnXZPlaneRing(float minRadius, float maxRadius)**
>Gets a random point in an annulus (a ring-shaped area) based on minimum and maximum radius values around a central Vector3 point (origin) on a the xz plane.

**Vector3 Vector3.With(float? x = null, float? y = null, float? z = null)**
>Sets any x y z values of a Vector3<br>
Source code from: https://github.com/adammyhre/Unity-Utils/blob/master/UnityUtils/Scripts/Extensions/Vector3Extensions.cs