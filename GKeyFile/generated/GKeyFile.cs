// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace KeyFile {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public class GKeyFile : GLib.Opaque {

		[DllImport("libglib-2.0.dll")]
		static extern IntPtr g_key_file_get_groups(IntPtr raw, out UIntPtr length);

		private string[] GetGroups(out ulong length) {
			UIntPtr native_length;
			IntPtr raw_ret = g_key_file_get_groups(Handle, out native_length);
			string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
			length = (ulong) native_length;
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern void g_key_file_set_boolean(IntPtr raw, IntPtr group_name, IntPtr key, bool value);

		public void SetBoolean(string group_name, string key, bool value) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			g_key_file_set_boolean(Handle, native_group_name, native_key, value);
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe IntPtr g_key_file_get_locale_string(IntPtr raw, IntPtr group_name, IntPtr key, IntPtr locale, out IntPtr error);

		public unsafe string GetLocaleString(string group_name, string key, string locale) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr native_locale = GLib.Marshaller.StringToPtrGStrdup (locale);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_key_file_get_locale_string(Handle, native_group_name, native_key, native_locale, out error);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
			GLib.Marshaller.Free (native_locale);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern void g_key_file_set_double(IntPtr raw, IntPtr group_name, IntPtr key, double value);

		public void SetDouble(string group_name, string key, double value) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			g_key_file_set_double(Handle, native_group_name, native_key, value);
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe bool g_key_file_remove_key(IntPtr raw, IntPtr group_name, IntPtr key, out IntPtr error);

		public unsafe bool RemoveKey(string group_name, string key) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_key_file_remove_key(Handle, native_group_name, native_key, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern void g_key_file_set_value(IntPtr raw, IntPtr group_name, IntPtr key, IntPtr value);

		public void SetValue(string group_name, string key, string value) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr native_value = GLib.Marshaller.StringToPtrGStrdup (value);
			g_key_file_set_value(Handle, native_group_name, native_key, native_value);
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
			GLib.Marshaller.Free (native_value);
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe bool g_key_file_remove_group(IntPtr raw, IntPtr group_name, out IntPtr error);

		public unsafe bool RemoveGroup(string group_name) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_key_file_remove_group(Handle, native_group_name, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_group_name);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe double g_key_file_get_double_list(IntPtr raw, IntPtr group_name, IntPtr key, out UIntPtr length, out IntPtr error);

		public unsafe double GetDoubleList(string group_name, string key, out ulong length) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			UIntPtr native_length;
			IntPtr error = IntPtr.Zero;
			double raw_ret = g_key_file_get_double_list(Handle, native_group_name, native_key, out native_length, out error);
			double ret = raw_ret;
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
			length = (ulong) native_length;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe bool g_key_file_remove_comment(IntPtr raw, IntPtr group_name, IntPtr key, out IntPtr error);

		public unsafe bool RemoveComment(string group_name, string key) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_key_file_remove_comment(Handle, native_group_name, native_key, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern void g_key_file_set_list_separator(IntPtr raw, IntPtr separator);

		public string ListSeparator { 
			set {
				g_key_file_set_list_separator(Handle, GLib.Marshaller.StringToPtrGStrdup(value));
			}
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe bool g_key_file_get_boolean_list(IntPtr raw, IntPtr group_name, IntPtr key, out UIntPtr length, out IntPtr error);

		public unsafe bool GetBooleanList(string group_name, string key, out ulong length) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			UIntPtr native_length;
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_key_file_get_boolean_list(Handle, native_group_name, native_key, out native_length, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
			length = (ulong) native_length;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern bool g_key_file_has_group(IntPtr raw, IntPtr group_name);

		public bool HasGroup(string group_name) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			bool raw_ret = g_key_file_has_group(Handle, native_group_name);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_group_name);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe bool g_key_file_set_comment(IntPtr raw, IntPtr group_name, IntPtr key, IntPtr comment, out IntPtr error);

		public unsafe bool SetComment(string group_name, string key, string comment) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr native_comment = GLib.Marshaller.StringToPtrGStrdup (comment);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_key_file_set_comment(Handle, native_group_name, native_key, native_comment, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
			GLib.Marshaller.Free (native_comment);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe int g_key_file_get_integer(IntPtr raw, IntPtr group_name, IntPtr key, out IntPtr error);

		public unsafe int GetInteger(string group_name, string key) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr error = IntPtr.Zero;
			int raw_ret = g_key_file_get_integer(Handle, native_group_name, native_key, out error);
			int ret = raw_ret;
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern void g_key_file_set_double_list(IntPtr raw, IntPtr group_name, IntPtr key, double[] list, UIntPtr length);

		private void SetDoubleList(string group_name, string key, double[] list, ulong length) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			g_key_file_set_double_list(Handle, native_group_name, native_key, list, new UIntPtr (length));
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe IntPtr g_key_file_get_locale_string_list(IntPtr raw, IntPtr group_name, IntPtr key, IntPtr locale, out UIntPtr length, out IntPtr error);

		public unsafe string[] GetLocaleStringList(string group_name, string key, string locale, out ulong length) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr native_locale = GLib.Marshaller.StringToPtrGStrdup (locale);
			UIntPtr native_length;
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_key_file_get_locale_string_list(Handle, native_group_name, native_key, native_locale, out native_length, out error);
			string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
			GLib.Marshaller.Free (native_locale);
			length = (ulong) native_length;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe bool g_key_file_get_boolean(IntPtr raw, IntPtr group_name, IntPtr key, out IntPtr error);

		public unsafe bool GetBoolean(string group_name, string key) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_key_file_get_boolean(Handle, native_group_name, native_key, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern void g_key_file_set_locale_string_list(IntPtr raw, IntPtr group_name, IntPtr key, IntPtr locale, IntPtr[] list, UIntPtr length);

		public void SetLocaleStringList(string group_name, string key, string locale, string[] list, ulong length) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr native_locale = GLib.Marshaller.StringToPtrGStrdup (locale);
			int cnt_list = list == null ? 0 : list.Length;
			IntPtr[] native_list = new IntPtr [cnt_list];
			for (int i = 0; i < cnt_list; i++)
				native_list [i] = GLib.Marshaller.StringToPtrGStrdup (list[i]);
			g_key_file_set_locale_string_list(Handle, native_group_name, native_key, native_locale, native_list, new UIntPtr (length));
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
			GLib.Marshaller.Free (native_locale);
			for (int i = 0; i < native_list.Length; i++) {
				list [i] = GLib.Marshaller.Utf8PtrToString (native_list[i]);
				GLib.Marshaller.Free (native_list[i]);
			}
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe IntPtr g_key_file_get_string_list(IntPtr raw, IntPtr group_name, IntPtr key, out UIntPtr length, out IntPtr error);

		private unsafe string[] GetStringList(string group_name, string key, out ulong length) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			UIntPtr native_length;
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_key_file_get_string_list(Handle, native_group_name, native_key, out native_length, out error);
			string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
			length = (ulong) native_length;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe IntPtr g_key_file_get_keys(IntPtr raw, IntPtr group_name, out UIntPtr length, out IntPtr error);

		private unsafe string[] GetKeys(string group_name, out ulong length) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			UIntPtr native_length;
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_key_file_get_keys(Handle, native_group_name, out native_length, out error);
			string[] ret = GLib.Marshaller.NullTermPtrToStringArray (raw_ret, false);
			GLib.Marshaller.Free (native_group_name);
			length = (ulong) native_length;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe bool g_key_file_load_from_data_dirs(IntPtr raw, IntPtr file, IntPtr full_path, int flags, out IntPtr error);

		public unsafe bool LoadFromDataDirs(string file, string full_path, KeyFile.Flags flags) {
			IntPtr native_file = GLib.Marshaller.StringToPtrGStrdup (file);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_key_file_load_from_data_dirs(Handle, native_file, GLib.Marshaller.StringToPtrGStrdup(full_path), (int) flags, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_file);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern void g_key_file_set_locale_string(IntPtr raw, IntPtr group_name, IntPtr key, IntPtr locale, IntPtr str1ng);

		public void SetLocaleString(string group_name, string key, string locale, string str1ng) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr native_locale = GLib.Marshaller.StringToPtrGStrdup (locale);
			IntPtr native_str1ng = GLib.Marshaller.StringToPtrGStrdup (str1ng);
			g_key_file_set_locale_string(Handle, native_group_name, native_key, native_locale, native_str1ng);
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
			GLib.Marshaller.Free (native_locale);
			GLib.Marshaller.Free (native_str1ng);
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe bool g_key_file_load_from_file(IntPtr raw, IntPtr file, int flags, out IntPtr error);

		public unsafe bool LoadFromFile(string file, KeyFile.Flags flags) {
			IntPtr native_file = GLib.Marshaller.StringToPtrGStrdup (file);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_key_file_load_from_file(Handle, native_file, (int) flags, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_file);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern void g_key_file_set_integer_list(IntPtr raw, IntPtr group_name, IntPtr key, int[] list, UIntPtr length);

		private void SetIntegerList(string group_name, string key, int[] list, ulong length) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			g_key_file_set_integer_list(Handle, native_group_name, native_key, list, new UIntPtr (length));
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
		}

		[DllImport("libglib-2.0.dll")]
		static extern void g_key_file_set_boolean_list(IntPtr raw, IntPtr group_name, IntPtr key, bool[] list, UIntPtr length);

		private void SetBooleanList(string group_name, string key, bool[] list, ulong length) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			g_key_file_set_boolean_list(Handle, native_group_name, native_key, list, new UIntPtr (length));
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe IntPtr g_key_file_to_data(IntPtr raw, out UIntPtr length, out IntPtr error);

		private unsafe string ToData(out ulong length) {
			UIntPtr native_length;
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_key_file_to_data(Handle, out native_length, out error);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			length = (ulong) native_length;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern void g_key_file_set_string_list(IntPtr raw, IntPtr group_name, IntPtr key, IntPtr[] list, UIntPtr length);

		private void SetStringList(string group_name, string key, string[] list, ulong length) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			int cnt_list = list == null ? 0 : list.Length;
			IntPtr[] native_list = new IntPtr [cnt_list];
			for (int i = 0; i < cnt_list; i++)
				native_list [i] = GLib.Marshaller.StringToPtrGStrdup (list[i]);
			g_key_file_set_string_list(Handle, native_group_name, native_key, native_list, new UIntPtr (length));
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
			for (int i = 0; i < native_list.Length; i++) {
				list [i] = GLib.Marshaller.Utf8PtrToString (native_list[i]);
				GLib.Marshaller.Free (native_list[i]);
			}
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe bool g_key_file_load_from_data(IntPtr raw, IntPtr data, UIntPtr length, int flags, out IntPtr error);

		public unsafe bool LoadFromData(string data, KeyFile.Flags flags) {
			IntPtr native_data = GLib.Marshaller.StringToPtrGStrdup (data);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_key_file_load_from_data(Handle, native_data, new UIntPtr ((ulong) System.Text.Encoding.UTF8.GetByteCount (data)), (int) flags, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_data);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern void g_key_file_set_string(IntPtr raw, IntPtr group_name, IntPtr key, IntPtr str1ng);

		public void SetString(string group_name, string key, string str1ng) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr native_str1ng = GLib.Marshaller.StringToPtrGStrdup (str1ng);
			g_key_file_set_string(Handle, native_group_name, native_key, native_str1ng);
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
			GLib.Marshaller.Free (native_str1ng);
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe double g_key_file_get_double(IntPtr raw, IntPtr group_name, IntPtr key, out IntPtr error);

		public unsafe double GetDouble(string group_name, string key) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr error = IntPtr.Zero;
			double raw_ret = g_key_file_get_double(Handle, native_group_name, native_key, out error);
			double ret = raw_ret;
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe IntPtr g_key_file_get_comment(IntPtr raw, IntPtr group_name, IntPtr key, out IntPtr error);

		public unsafe string GetComment(string group_name, string key) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_key_file_get_comment(Handle, native_group_name, native_key, out error);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern int g_key_file_error_quark();

		public static int ErrorQuark() {
			int raw_ret = g_key_file_error_quark();
			int ret = raw_ret;
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe bool g_key_file_has_key(IntPtr raw, IntPtr group_name, IntPtr key, out IntPtr error);

		public unsafe bool HasKey(string group_name, string key) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_key_file_has_key(Handle, native_group_name, native_key, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe bool g_key_file_load_from_dirs(IntPtr raw, IntPtr file, IntPtr search_dirs, IntPtr full_path, int flags, out IntPtr error);

		public unsafe bool LoadFromDirs(string file, string search_dirs, string full_path, KeyFile.Flags flags) {
			IntPtr native_file = GLib.Marshaller.StringToPtrGStrdup (file);
			IntPtr native_search_dirs = GLib.Marshaller.StringToPtrGStrdup (search_dirs);
			IntPtr error = IntPtr.Zero;
			bool raw_ret = g_key_file_load_from_dirs(Handle, native_file, native_search_dirs, GLib.Marshaller.StringToPtrGStrdup(full_path), (int) flags, out error);
			bool ret = raw_ret;
			GLib.Marshaller.Free (native_file);
			GLib.Marshaller.Free (native_search_dirs);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe IntPtr g_key_file_get_value(IntPtr raw, IntPtr group_name, IntPtr key, out IntPtr error);

		public unsafe string GetValue(string group_name, string key) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_key_file_get_value(Handle, native_group_name, native_key, out error);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe int g_key_file_get_integer_list(IntPtr raw, IntPtr group_name, IntPtr key, out UIntPtr length, out IntPtr error);

		public unsafe int GetIntegerList(string group_name, string key, out ulong length) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			UIntPtr native_length;
			IntPtr error = IntPtr.Zero;
			int raw_ret = g_key_file_get_integer_list(Handle, native_group_name, native_key, out native_length, out error);
			int ret = raw_ret;
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
			length = (ulong) native_length;
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		[DllImport("libglib-2.0.dll")]
		static extern IntPtr g_key_file_get_start_group(IntPtr raw);

		public string StartGroup { 
			get {
				IntPtr raw_ret = g_key_file_get_start_group(Handle);
				string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
				return ret;
			}
		}

		[DllImport("libglib-2.0.dll")]
		static extern void g_key_file_set_integer(IntPtr raw, IntPtr group_name, IntPtr key, int value);

		public void SetInteger(string group_name, string key, int value) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			g_key_file_set_integer(Handle, native_group_name, native_key, value);
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
		}

		[DllImport("libglib-2.0.dll")]
		static extern unsafe IntPtr g_key_file_get_string(IntPtr raw, IntPtr group_name, IntPtr key, out IntPtr error);

		public unsafe string GetString(string group_name, string key) {
			IntPtr native_group_name = GLib.Marshaller.StringToPtrGStrdup (group_name);
			IntPtr native_key = GLib.Marshaller.StringToPtrGStrdup (key);
			IntPtr error = IntPtr.Zero;
			IntPtr raw_ret = g_key_file_get_string(Handle, native_group_name, native_key, out error);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			GLib.Marshaller.Free (native_group_name);
			GLib.Marshaller.Free (native_key);
			if (error != IntPtr.Zero) throw new GLib.GException (error);
			return ret;
		}

		public GKeyFile(IntPtr raw) : base(raw) {}

		[DllImport("libglib-2.0.dll")]
		static extern IntPtr g_key_file_new();

		public GKeyFile () 
		{
			Raw = g_key_file_new();
		}

		[DllImport("libglib-2.0.dll")]
		static extern void g_key_file_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			g_key_file_free (raw);
		}

#endregion
#region Customized extensions
#line 1 "GKeyFile.custom"
/*
 * GKeyFile.custom
 *
 * Author(s):
 *	Stephane Delcroix  (stephane@delcroix.org)
 *
 * Copyright (c) 2008 Novell, Inc.
 *
 * 
 * Permission is hereby granted, free of charge, to any person obtaining
 * a copy of this software and associated documentation files (the
 * "Software"), to deal in the Software without restriction, including
 * without limitation the rights to use, copy, modify, merge, publish,
 * distribute, sublicense, and/or sell copies of the Software, and to
 * permit persons to whom the Software is furnished to do so, subject to
 * the following conditions:
 * 
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
 * LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
 * OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
 * WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 *
 */

	public GKeyFile (string file, KeyFile.Flags flags) : this ()
	{
		LoadFromFile (file, flags);
	}

	public GKeyFile (string file) : this (file, KeyFile.Flags.KeepComments)
	{
	}

	public string ToData ()
	{
		ulong length;
		return ToData (out length);
	}

	public void Save (string filename)
	{
		byte [] content = System.Text.Encoding.Default.GetBytes (ToData ());
		System.IO.FileStream stream = System.IO.File.Create (filename);
		stream.Write (content, 0, content.Length);
		stream.Close ();
	}
	
	public void SetStringList(string group_name, string key, string[] list) {
		SetStringList (group_name, key, list, (ulong)list.Length);
	}

	public void SetBooleanList(string group_name, string key, bool[] list) {
		SetBooleanList(group_name, key, list, (ulong)list.Length);
	}
	
	public void SetIntegerList(string group_name, string key, int[] list) {
		SetIntegerList (group_name, key, list, (ulong)list.Length);
	}

	public void SetDoubleList(string group_name, string key, double[] list) {
		SetDoubleList (group_name, key, list, (ulong)list.Length);
	}

	public string [] GetKeys (string group_name) {
		ulong length;
		return GetKeys (group_name, out length);
	}

	public string [] GetGroups () {
		ulong length;
		return GetGroups (out length);
	}

	public string[] GetStringList(string group_name, string key) {
		ulong length;
		return GetStringList (group_name, key, out length);
	}

//	public bool[] GetBooleanList(string group_name, string key) {
//		ulong length;
//		return GetBooleanList (group_anme, key, out length);
//	}
//	
//	public int[] GetIntegerList(string group_name, string key) {
//		ulong length;
//		return GetIntegerList (group_name, key, out length);
//	}
//
//	public double[] GetDoubleList(string group_name, string key) {
//		ulong length;
//		return GetDoubleList (group_name, key, out length);
//	}

#endregion
	}
}
