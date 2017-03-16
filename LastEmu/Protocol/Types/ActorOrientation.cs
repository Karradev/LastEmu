using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class ActorOrientation
	{
		public const short Id = 353;

		public double id;

		public sbyte direction;

		public virtual short TypeId
		{
			get
			{
				return 353;
			}
		}

		public ActorOrientation()
		{
		}

		public ActorOrientation(double id, sbyte direction)
		{
			this.id = id;
			this.direction = direction;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadDouble();
			this.direction = reader.ReadSByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.id);
			writer.WriteSByte(this.direction);
		}
	}
}