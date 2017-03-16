using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class AbstractCharacterInformation
	{
		public const short Id = 400;

		public double id;

		public virtual short TypeId
		{
			get
			{
				return 400;
			}
		}

		public AbstractCharacterInformation()
		{
		}

		public AbstractCharacterInformation(double id)
		{
			this.id = id;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.id = reader.ReadVarUhLong();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.id);
		}
	}
}