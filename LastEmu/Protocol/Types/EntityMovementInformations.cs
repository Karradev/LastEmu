using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class EntityMovementInformations
	{
		public const short Id = 63;

		public int id;

		public sbyte[] steps;

		public virtual short TypeId
		{
			get
			{
				return 63;
			}
		}

		public EntityMovementInformations()
		{
		}

		public EntityMovementInformations(int id, sbyte[] steps)
		{
			this.id = id;
			this.steps = steps;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadInt();
			ushort num = (ushort)reader.ReadVarInt();
			this.steps = new sbyte[num];
			for (int i = 0; i < num; i++)
			{
				this.steps[i] = reader.ReadSByte();
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.id);
			writer.WriteVarInt((int)((int)this.steps.Length));
			sbyte[] numArray = this.steps;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteSByte(numArray[i]);
			}
		}
	}
}