public struct Maybe<T> {
  private T? _value;
  public readonly T? GetValue { get { return _value; } }
  public Maybe(T? data) {
    _value = data;
  }
  public static Maybe<T> None() {
    return new Maybe<T>();
  }
  public static Maybe<T> FromValue(T? currentData) {
    Maybe<T> maybe;
    maybe._value = currentData;
    return maybe;
  }
  public static Maybe<T> Some(T? value) {
    if(value == null) {
      throw new ArgumentNullException(nameof(value));
    }
    return Maybe<T>.FromValue(value);
  }
  public readonly bool IsEmpty() {
    return _value == null;
  }
  public readonly T GetOrElse(T defaultValue) {
    return _value == null ? defaultValue : _value;
  }
  public readonly Maybe<R> Map<R>(Func<T, R> mapper) {
    return _value == null ? new Maybe<R>() : Maybe<R>.Some(mapper(_value));
  }
  public readonly Maybe<R> FlatMap<R>(Func<T, Maybe<R>> mapper) {
    return _value == null ? new Maybe<R>() : mapper(_value);
  }
}
