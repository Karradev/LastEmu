using System;

namespace Protocol.IO
{
	public static class BooleanByteWrapper
	{
		public static bool GetFlag(byte flag, byte offset)
		{
			if (offset >= 8)
			{
				throw new ArgumentException("offset must be lesser than 8");
			}
			var flag1 = (flag & (byte)(1 << (offset & 31))) != 0;
			return flag1;
		}

		public static byte SetFlag(byte flag, byte offset, bool value)
		{
			if (offset >= 8)
			{
				throw new ArgumentException("offset must be lesser than 8");
			}
			return (value ? (byte)(flag | 1 << (offset & 31)) : (byte)(flag & 255 - (1 << (offset & 31))));
		}

		public static byte SetFlag(int flag, byte offset, bool value)
		{
			if (offset >= 8)
			{
				throw new ArgumentException("offset must be lesser than 8");
			}
			return (value ? (byte)(flag | 1 << (offset & 31)) : (byte)(flag & 255 - (1 << (offset & 31))));
		}
	}
}