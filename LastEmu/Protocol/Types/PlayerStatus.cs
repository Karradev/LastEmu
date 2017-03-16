using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class PlayerStatus
	{
		public const short Id = 415;

		public sbyte statusId;

		public virtual short TypeId
		{
			get
			{
				return 415;
			}
		}

		public PlayerStatus()
		{
		}

		public PlayerStatus(sbyte statusId)
		{
			this.statusId = statusId;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.statusId = reader.ReadSByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.statusId);
		}
	}
}