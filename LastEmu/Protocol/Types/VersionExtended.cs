using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class VersionExtended : Version
	{
		public const short Id = 393;

		public sbyte install;

		public sbyte technology;

	    public override short TypeId
		{
			get
			{
				return 393;
			}
		}

		public VersionExtended()
		{
		}

		public VersionExtended(sbyte major, sbyte minor, sbyte release, int revision, sbyte patch, sbyte buildType, sbyte install, sbyte technology) : base(major, minor, release, revision, patch, buildType)
		{
			this.install = install;
			this.technology = technology;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.install = reader.ReadSByte();
			this.technology = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteSByte(this.install);
			writer.WriteSByte(this.technology);
		}
	}
}