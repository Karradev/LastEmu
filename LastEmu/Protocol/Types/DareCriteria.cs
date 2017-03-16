using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class DareCriteria
	{
		public const short Id = 501;

		public sbyte type;

		public int[] _params;

		public virtual short TypeId
		{
			get
			{
				return 501;
			}
		}

		public DareCriteria()
		{
		}

		public DareCriteria(sbyte type, int[] _params)
		{
			this.type = type;
			this._params = _params;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.type = reader.ReadSByte();
			ushort num = reader.ReadUShort();
			this._params = new int[num];
			for (int i = 0; i < num; i++)
			{
				this._params[i] = reader.ReadInt();
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.type);
			writer.WriteShort((short)((int)this._params.Length));
			int[] numArray = this._params;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteInt(numArray[i]);
			}
		}
	}
}