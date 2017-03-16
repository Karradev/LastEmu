using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ObjectEffect
	{
		public const short Id = 76;

		public uint actionId;

		public virtual short TypeId
		{
			get
			{
				return 76;
			}
		}

		public ObjectEffect()
		{
		}

		public ObjectEffect(uint actionId)
		{
			this.actionId = actionId;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.actionId = reader.ReadVarUhShort();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.actionId);
		}
	}
}