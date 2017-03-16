using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ServerSessionConstant
	{
		public const short Id = 430;

		public uint id;

		public virtual short TypeId
		{
			get
			{
				return 430;
			}
		}

		public ServerSessionConstant()
		{
		}

		public ServerSessionConstant(uint id)
		{
			this.id = id;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadVarUhShort();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.id);
		}
	}
}